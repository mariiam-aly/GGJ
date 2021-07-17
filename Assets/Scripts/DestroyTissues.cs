using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTissues : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController player;
    void Start()
    {
        player= FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Dead==true){

     Destroy(gameObject);
        
         }
    }
}
