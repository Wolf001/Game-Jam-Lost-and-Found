using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void btnChangeScene(string s)
    {
        if(s == "Exit")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(s);
        }
    }
}
