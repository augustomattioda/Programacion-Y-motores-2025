using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject shooter;

    [SerializeField]
    float bulletspeed;
    private void FixedUpdate()
    {
        transform.position += transform.up * bulletspeed * Time.fixedDeltaTime;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
    }

   
}
