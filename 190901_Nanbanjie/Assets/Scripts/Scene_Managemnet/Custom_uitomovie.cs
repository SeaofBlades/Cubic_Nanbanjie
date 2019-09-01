using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_uitomovie : MonoBehaviour
{
    public GameObject Movie, pause_button;
    public void Video_Play()
    {
        Movie.SetActive(true);
        pause_button.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
