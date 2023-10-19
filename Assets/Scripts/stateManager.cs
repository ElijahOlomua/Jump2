using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stateManager : MonoBehaviour
{
    public void reloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void quitGame() 
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
