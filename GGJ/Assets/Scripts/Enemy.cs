using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     public float speed;
 private Transform target;
public PlayerController player;
public int size=0;
public bool dies;

    // Start is called before the first frame update
    void Start()
    {
        player= FindObjectOfType<PlayerController>();
         
         target = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         
        Physics.IgnoreLayerCollision(10,11, true);
   
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    transform.LookAt(target.position);
   if(player.Dead==true){

       Destroy(gameObject);
   }
   }
    private void OnCollisionEnter(Collision collider)
{ if (collider.gameObject.tag == "ToiletPaper")
    {
        Destroy(collider.gameObject);
      speed+=1.2f;
    }
    else if (collider.gameObject.tag == "ToiletPaper2")
    {
        Destroy(collider.gameObject);
      transform.localScale += new Vector3 (0.6f,0.6f,0.6f);
      size+=1;
    }
   

     
  
}
 private void OnTriggerEnter(Collider other)
    {
if(other.gameObject.tag == "Player")
    {
      size-=1;
      transform.localScale -= new Vector3 (0.6f,0.6f,0.6f);
      
    }
  else  if(other.gameObject.tag == "Water")
    {
      size-=1;
      transform.localScale -= new Vector3 (0.6f,0.6f,0.6f);
      
    }
    if(size==0){
Destroy(gameObject);

    }


}



 }