using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampadebrea : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<iaffectedspeed>() != null) 
        {
            collision.gameObject.GetComponent<iaffectedspeed>().takeSpeed(5);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<iaffectedspeed>() != null)
        {
            collision.gameObject.GetComponent<iaffectedspeed>().restoreSpeed(5);
        }
    }
   
}
