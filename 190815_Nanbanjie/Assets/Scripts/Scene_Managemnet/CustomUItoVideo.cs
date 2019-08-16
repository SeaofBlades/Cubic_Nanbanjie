using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CustomUItoVideo : MonoBehaviour
{
    public GameObject UI_Panel, pause_button;
    void Start()
    {
        gameObject.GetComponent<VideoPlayer>().loopPointReached += EndReached;
    }

    public void button_close()
    {
        UI_Panel.SetActive(true);
        pause_button.SetActive(true);
        this.gameObject.SetActive(false);
    }
    private void EndReached(VideoPlayer vp)
    {
        UI_Panel.SetActive(true);
        pause_button.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
