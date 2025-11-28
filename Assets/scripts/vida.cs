using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    [SerializeField]
    GameObject[] corazones;

    [SerializeField]
    public int currentlife = 7;

    public void takedamage()
    {
        

        if (currentlife > 0)
        {
            currentlife--;
            Debug.Log("Daño");

            if (currentlife <= 0)
            {
               SceneManager.LoadScene("derrota");
            }
            else
            corazones[currentlife - 1].SetActive(false);
        }

       
    }
    public void getlife()
    {
        if (currentlife < 7)
        {
            corazones[currentlife].SetActive(true);

            if (currentlife > 0)
            {
                currentlife++;

            }
        }
    }
}
