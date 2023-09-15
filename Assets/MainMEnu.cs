using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;


public class MainMEnu : MonoBehaviour
{
   
    public void PlayGame()
    {
        
        SceneManager.LoadScene("Scene1");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public void LoadMenu()
    {
        
        
        
        SceneManager.LoadScene("Main Menu");
        
    }
}