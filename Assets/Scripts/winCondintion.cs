using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class winCondintion : MonoBehaviour
{
    public GameObject timerManagerObject;
    public GameObject player;
    public TextMeshProUGUI playerCompletionTime;
    public TextMeshProUGUI playerHighScoreText;
    //public int playerHighScore;
    //string playerCompletionTime;
    float tempPlayerTime;
    public AudioSource winSound;
    void Start()
    {
        playerHighScoreText.text = PlayerPrefs.GetFloat("HighScore", 99999f).ToString();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        timerManagScript playerTime = timerManagerObject.GetComponent<timerManagScript>();
        

        tempPlayerTime = playerTime.currentTime;
        TimeSpan time = TimeSpan.FromSeconds(tempPlayerTime);
       

        levelManager.instance.GameWin();
        playerCompletionTime.text = time.ToString(@"mm\:ss\:ff");
        if (tempPlayerTime < PlayerPrefs.GetFloat("HighScore", 99999f))
        {
            PlayerPrefs.SetFloat("HighScore", tempPlayerTime);
            playerHighScoreText.text = time.ToString(@"mm\:ss\:ff");
            Debug.Log(playerHighScoreText.text);
        }
        winSound.Play();

        
    }
    void OnCollisionStay2D(Collision2D other) 
    {
        movementScript playermove = player.GetComponent<movementScript>();
        playermove.canJump = false;
    }
}
