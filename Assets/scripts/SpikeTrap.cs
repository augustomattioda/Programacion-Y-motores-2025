using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpikeTrap : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        vida vidaplayer = collision.gameObject.GetComponent<vida>();

        if (vidaplayer != null) 
        {
            vidaplayer.takedamage();
        }
    }
}
