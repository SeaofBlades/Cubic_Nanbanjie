using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMusic : MonoBehaviour
{
    AudioSource Main_Audio;
    void Start()
    {
        Main_Audio = GameObject.Find("Background Music").GetComponent<AudioSource>();
        Main_Audio.Pause();
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void OnEnable()
    {
        Main_Audio = GameObject.Find("Background Music").GetComponent<AudioSource>();
        Main_Audio.Pause();
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void OnDisable()
    {
        Main_Audio.Play();
    }

    void Update()
    {
        
    }
}
