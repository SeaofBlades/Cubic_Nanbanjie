using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UI_Next_Scene : MonoBehaviour
{
    public GameObject next_movie;
    public Video_Player_Fix Curr_vid;
    public List<GameObject> previous_objects;


    private void Start()
    {
        Curr_vid.previous.Clear();
        for (int i = 0; i < previous_objects.Count; i++)
        {
            Curr_vid.previous.Add(previous_objects[i]);
        }
        Curr_vid.next.Clear();
        Curr_vid.next.Add(next_movie);
    }
    void OnEnable()
    {
        Curr_vid.previous.Clear();
        for (int i = 0; i < previous_objects.Count; i++)
        {
            Curr_vid.previous.Add(previous_objects[i]);
        }
        Curr_vid.next.Clear();
        Curr_vid.next.Add(next_movie);
    }
    public void Start_game()
    {
       
        Curr_vid.active.Clear();
        Curr_vid.active.Add(next_movie);
        next_movie.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
