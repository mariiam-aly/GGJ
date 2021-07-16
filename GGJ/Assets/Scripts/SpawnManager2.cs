using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
        public GameObject enemyPrefab;
        public float startdelay=0.5f;
        public float spawnInterval=3;
        public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player= FindObjectOfType<PlayerController>();
        InvokeRepeating("SpawnRandomAnimal",startdelay,spawnInterval );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
{
    int[] choices = {-10,10};
int myRandomIndex = Random.Range( 0, choices.Length );
 int result = choices[myRandomIndex];
    float posz= Random.Range(-6,6);
        Vector3 randompos= new Vector3(result,transform.position.y,posz);
      GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
       if(player.Dead==false && gos.Length<3){
        Instantiate(enemyPrefab, randompos,enemyPrefab.transform.rotation );

}}
}
