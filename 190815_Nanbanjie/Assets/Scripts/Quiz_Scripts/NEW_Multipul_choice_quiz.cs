using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NEW_Multipul_choice_quiz : MonoBehaviour
{
    public GameObject Pause_Button, Next_Button, Replay_Button;
    public List<GameObject> Question_List;
    [HideInInspector]
    public List<GameObject> Quiz_List;
    bool triva_finished = false, triva_started = false;
    public int score = 0;
    public TextMeshProUGUI Final_Score;

    private void FixedUpdate()
    {
        
        Next_Button.SetActive(triva_finished);
        Replay_Button.SetActive(triva_finished);
        if (triva_finished == false && triva_started == false)
        {
            Pause_Button.SetActive(false);
            triva_started = true;
            Triva_Go();
        }
        if (triva_finished == true)
        {
            Final_Score.SetText("You got " + score.ToString() + " out of " + Question_List.Count.ToString() + " correct!");
        }
    }

    private void Triva_Go()
    {
        int MaxNum = Question_List.Count;
        for (int i = 0; i < 5; i++)
        {
            int tempnum = Random.Range(0, MaxNum);
            Quiz_List.Add(Question_List[tempnum]);
            Question_List.RemoveAt(tempnum);
            MaxNum--;
        }
        Quiz_List[0].SetActive(true);
    }
    public void next_scene()
    {
        score = 0;
        Final_Score.SetText("");
        triva_finished = false;
        triva_started = false;
        Pause_Button.SetActive(true);
        gameObject.GetComponent<UI_Next_Scene>().Start_game();
    }
    public void Replay()
    {
        score = 0;
        Final_Score.SetText("");
        triva_finished = false;
        triva_started = false;
    }
    public void next_question()
    {
        for (int i = 0; i < Quiz_List[0].GetComponent<Button_Tracker>().answers.Count; i++)
        {
            Quiz_List[0].GetComponent<Button_Tracker>().answers[i].GetComponent<Image>().color = Color.white;
            Quiz_List[0].GetComponent<Button_Tracker>().answers[i].GetComponent<Button>().interactable = true;
        }
        Quiz_List[0].SetActive(false);
        Question_List.Add(Quiz_List[0]);
        Quiz_List.RemoveAt(0);
        if (Quiz_List.Count > 0)
        {
            Quiz_List[0].SetActive(true);
        }
        else
        {
            triva_finished = true;
        }
    }
}
