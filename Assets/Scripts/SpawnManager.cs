using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
     public float startdelay=0.5f;
        public float spawnInterval=5;
        public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player= FindObjectOfType<PlayerController>();
         InvokeRepeating("SpawnRandomAnimal",startdelay,spawnInterval ); }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
{
    int[] choices = {-6,6};
int myRandomIndex = Random.Range( 0, choices.Length );
 int result = choices[myRandomIndex];
        float posx= Random.Range(-10,10);
        Vector3 randompos= new Vector3(posx,transform.position.y,result);
       
GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");

         if(player.Dead==false && gos.Length<4){
        Instantiate(enemyPrefab, randompos,enemyPrefab.transform.rotation );
         }
}
}
