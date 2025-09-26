using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarsi : MonoBehaviour
{
   public void gotoscene(string level)
   {
        SceneManager.LoadScene(level);

   }

    public void exitgame()
    {
        Application.Quit();

    }


}
