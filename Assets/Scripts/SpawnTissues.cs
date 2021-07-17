using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTissues : MonoBehaviour
{
    public GameObject[] Tissues;
    
     public float startdelay=0.1f;
        public float spawnInterval;
         public PlayerController player;
         private GameManager gameManager; 
         int[] interval_value= {5,3,2};

    // Start is called before the first frame update
    void Start()
    {
        int diff_index= PlayerPrefs.GetInt("difficulty");
       
        spawnInterval= interval_value[diff_index];
 Debug.Log(spawnInterval);
         player= FindObjectOfType<PlayerController>();
         InvokeRepeating("SpawnRandomTissues",startdelay,spawnInterval );
   gameManager= GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    /*   if(gameManager.score==15){
    spawnInterval+=5;
       }*/
   }
    
    void SpawnRandomTissues()
{
    int TType= Random.Range(0,2);
        float posx= Random.Range(7.3f,-7.3f);
        float posz= Random.Range(3.7f,-3.7f);
        Vector3 randompos= new Vector3(posx,Tissues[TType].transform.position.y,posz);
       
/*GameObject[] gos1 = GameObject.FindGameObjectsWithTag("ToiletPaper");
GameObject[] gos2 = GameObject.FindGameObjectsWithTag("ToiletPaper2");
int gos= gos1.Length + gos2.Length;*/
         if(player.Dead==false){
        Instantiate(Tissues[TType], randompos,Tissues[TType].transform.rotation );
         }
}
}
