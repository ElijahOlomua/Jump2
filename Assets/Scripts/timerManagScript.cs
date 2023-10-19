using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class timerManagScript : MonoBehaviour
{
    public TextMeshProUGUI currenTimeText;
    bool stopWatchActive;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        StartStopWatch();
    }

    // Update is called once per frame
    void Update()
    {
        if (stopWatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currenTimeText.text = time.ToString(@"mm\:ss\:ff");
    }
    public void StartStopWatch()
    {
        stopWatchActive = true;
    }
    public void StopStartWatch()
    {
        stopWatchActive = false;
    }
}
