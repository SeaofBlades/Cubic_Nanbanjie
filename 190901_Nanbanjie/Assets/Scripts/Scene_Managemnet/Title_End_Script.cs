using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Title_End_Script : MonoBehaviour
{
    public GameObject Pause_Button;
    public GameObject next_movie;
    public Video_Player_Fix Curr_vid;

    void Start()
    {
        Curr_vid.next.Clear();
        Curr_vid.next.Add(next_movie);
    }
    private void FixedUpdate()
    {
        Pause_Button.SetActive(false);
    }
    public void Start_game()
    {
        
        Curr_vid.active.Clear();
        Curr_vid.active.Add(next_movie);
        Pause_Button.SetActive(true);
        next_movie.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
