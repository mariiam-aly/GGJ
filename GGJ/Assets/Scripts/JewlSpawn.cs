using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewlSpawn : MonoBehaviour
{
    public GameObject[] Jewls;
    
     public float startdelay=0.1f;
        public float spawnInterval=10;
         public PlayerController player;
         private GameManager gameManager; 
    // Start is called before the first frame update
    void Start()
    {
         player= FindObjectOfType<PlayerController>();
         InvokeRepeating("SpawnRandomJewls",startdelay,spawnInterval );
   gameManager= GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
   }
    
    void SpawnRandomJewls()
{
    int TType= Random.Range(0,2);
        float posx= Random.Range(7.3f,-7.3f);
        float posz= Random.Range(3.7f,-3.7f);
        Vector3 randompos= new Vector3(posx,Jewls[TType].transform.position.y,posz);
       

         if(player.Dead==false){
        Instantiate(Jewls[TType], randompos,Jewls[TType].transform.rotation );
         }
}
}
