using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float Turnspeed;
    public float horizontalInput;
    private float verticalInput;
    private Animator playerAnim;
    public GameObject projectilePrefab;
     public float HBound;
    public float VpBound;
    private GameManager gameManager; 
    public bool Dead;
    public bool vulnerable= true;
     public GameObject Tornado;
   public Enemy enemy;
    //public GameObject Jewel;
    void Start()
    {
        enemy= FindObjectOfType<Enemy>();
        gameManager= GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        death();
        vulnerablity();
        horizontalInput =  Input.GetAxis("Horizontal");
        verticalInput =  Input.GetAxis("Vertical");
         if(!Dead){
         transform.Rotate(Vector3.up, horizontalInput*Time.deltaTime*Turnspeed);
          transform.Translate(Vector3.forward*verticalInput*Time.deltaTime*speed);
         }
if (transform.position.x > HBound ) {
transform.position=new Vector3(HBound, transform.position.y,transform.position.z); }
if(transform.position.x < -HBound){
transform.position=new Vector3(-HBound, transform.position.y,transform.position.z); 
    }
    if (transform.position.z > VpBound ) {
transform.position=new Vector3( transform.position.x, transform.position.y,VpBound); }
if(transform.position.z < -VpBound){
transform.position=new Vector3(transform.position.x, transform.position.y,-VpBound); 
    }
     
     if (horizontalInput !=0 || verticalInput !=0)
     {
           playerAnim.SetBool("isRunning", true);
     }
     else{
         playerAnim.SetBool("isRunning", false);
     }
     if (Input.GetKeyDown(KeyCode.Space) && !Dead) {
     Instantiate(projectilePrefab, transform.position + new Vector3(0,1,0),  transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collider)
{
   /*  if (collider.gameObject.CompareTag("Enemy"))
     {
        
gameManager.UpdateLives(1);
       vulnerable= false;
       StartCoroutine(TookHit());
Destroy(collider.gameObject); 
       Instantiate(Tornado, collider.gameObject.transform.position + new Vector3(0,0.7f,0),Tornado.transform.rotation );

    }*/




 if (collider.gameObject.tag == "Jewel")
    {
        Destroy(collider.gameObject);
       gameManager.UpdateScore(1);
    }
else if (collider.gameObject.tag == "ToiletPaper")
    {
        Destroy(collider.gameObject);
      
    }
    else if (collider.gameObject.tag == "ToiletPaper2")
    {
        Destroy(collider.gameObject);
      
    }
    
}
 
 private void death(){
if(gameManager.Lives==0){
    playerAnim.SetBool("isDead", true);
    Dead= true;
    
}}

/*private void Jewles(){
   if(Dead==true){
           Jewel.GetComponent<AnimationScript>().enabled= false;
        
    }
    
}*/

 
IEnumerator TookHit() {

  yield return new WaitForSeconds(1.5f);
  vulnerable= true;
     }
    private void vulnerablity(){
        if(vulnerable == false){

   Physics.IgnoreLayerCollision(9,10, true);}
        else{
Physics.IgnoreLayerCollision(9,10, false);

        }

    }
     private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Enemy"))
     {
        
gameManager.UpdateLives(1);
       vulnerable= false;
       StartCoroutine(TookHit());
//Destroy(other.gameObject); 
       Instantiate(Tornado, other.gameObject.transform.position + new Vector3(0,0.7f,0),Tornado.transform.rotation );

    }
    }
}