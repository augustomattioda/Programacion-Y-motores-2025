using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class cambioporcolision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject) 
        {
            SceneManager.LoadScene("victoria");
        }
    }
    public void gotoscene(string level)
    {
        SceneManager.LoadScene(level);

    }
}
