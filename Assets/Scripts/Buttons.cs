using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene("Wave 1");
    }
    public void startmenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
   
}
