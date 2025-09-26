using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corazones : MonoBehaviour
{
    vida vidaplayer;

    private void Start()
    {
        vidaplayer = GetComponent<vida>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("corazon") && vidaplayer.currentlife < 4)
        {

            if (vidaplayer != null)
            {
                vidaplayer.getlife();
            }
            Destroy(other.gameObject);
        }

    }
}
