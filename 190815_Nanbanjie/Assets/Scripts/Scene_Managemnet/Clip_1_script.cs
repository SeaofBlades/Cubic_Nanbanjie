using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Clip_1_script : MonoBehaviour
{
    public GameObject Next_video, UI_Elemnts;
    public Video_Player_Fix Vid_Fix;
    public List<GameObject> previous_objects;

    private void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
        Vid_Fix.previous.Clear();
        for (int i = 0; i < previous_objects.Count; i++)
        {
            Vid_Fix.previous.Add(previous_objects[i]);
        }
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_video);
        Vid_Fix.next.Add(UI_Elemnts);
    }
    void OnEnable()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
        Vid_Fix.previous.Clear();
        for (int i = 0; i < previous_objects.Count; i++)
        {
            Vid_Fix.previous.Add(previous_objects[i]);
        }
        Vid_Fix.next.Clear();
        Vid_Fix.next.Add(Next_video);
        Vid_Fix.next.Add(UI_Elemnts);
    }

   private void EndReached(VideoPlayer vp)
    {
        Vid_Fix.active.Clear();
        Vid_Fix.active.Add(Next_video);
        Vid_Fix.active.Add(UI_Elemnts);
        Next_video.SetActive(true);
        UI_Elemnts.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
