using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{
    [SerializeField] Slider Volumeslider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else {
            loadAudio();
        }
    }

    public void changeVolume()
    {
        AudioListener.volume = Volumeslider.value;
        saveAudio();
    }
    public void loadAudio()
    {
        Volumeslider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    public void saveAudio()
    {
        PlayerPrefs.SetFloat("musicVolume", Volumeslider.value);
    }

}
