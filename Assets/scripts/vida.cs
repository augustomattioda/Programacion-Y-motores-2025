using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    [SerializeField]
    GameObject[] corazones;

    [SerializeField]
    public int currentlife = 4;

    public void takedamage()
    {
        corazones[currentlife - 1].SetActive(false);

        if (currentlife > 0)
        {
            currentlife--;
            Debug.Log("Daño");
        }

        if (currentlife <= 0)
        {
            SceneManager.LoadScene("derrota");
        }

    }
    public void getlife()
    {
        if (currentlife < 4)
        {
            corazones[currentlife].SetActive(true);

            if (currentlife > 0)
            {
                currentlife++;

            }
        }
    }
}
