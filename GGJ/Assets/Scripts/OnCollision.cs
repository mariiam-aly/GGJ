using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject[] Jewel;
    public GameObject Tornado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
{
     if (other.gameObject.CompareTag("Enemy"))
     {
         Destroy(gameObject);
        
         int jewelindex = Random.Range(0, Jewel.Length);
          Instantiate(Jewel[jewelindex], other.gameObject.transform.position + new Vector3(0,0.7f,0),Jewel[jewelindex].transform.rotation );
Instantiate(Tornado, other.gameObject.transform.position + new Vector3(0,0.7f,0),Tornado.transform.rotation );

}
}
}
