using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UItoLoop : MonoBehaviour
{
    public GameObject next_movie, UI_Element;
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
        Curr_vid.next.Add(UI_Element);
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
        Curr_vid.next.Add(UI_Element);
    }
    public void Start_game()
    {

        Curr_vid.active.Clear();
        Curr_vid.active.Add(next_movie);
        Curr_vid.active.Add(UI_Element);
        next_movie.SetActive(true);
        UI_Element.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
