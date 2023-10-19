using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public static levelManager instance;

    private void Awake() 
    {
        if (levelManager.instance == null) instance = this;
        else Destroy(gameObject);
    }
    public void GameOver() 
    {
        uiManager _ui = GetComponent<uiManager>();
        if (_ui != null) 
        {
            _ui.ToggleDeathPanel();
        }
    }
    public void GameWin() 
    {
        uiManager _ui = GetComponent<uiManager>();
        if (_ui != null)
        {
            _ui.ToggleWinPanel();
        }
    }
}
