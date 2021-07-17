using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float HBound;
    public float VpBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > VpBound || transform.position.z < -VpBound) {
Destroy(gameObject); }

if (transform.position.x > HBound || transform.position.x < -HBound) {
Destroy(gameObject); }
        
    }
}
