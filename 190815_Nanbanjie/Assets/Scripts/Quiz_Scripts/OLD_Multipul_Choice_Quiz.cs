using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class OLD_Multipul_Choice_Quiz : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public string Question_text;
        public List<Answer> Answers;
    }
    [System.Serializable]
    public class Answer
    {
        public string Answer_text;
        public bool correct;
    }

    public List<Question> Question_List, Quiz_List;
    public GameObject Pause_Button, answer1_button, answer2_button, answer3_button;
    public TextMeshProUGUI Question_Text, answer1_text, answer2_text, answer3_text;
    bool triva_finished = false, triva_started = false;

    

    private void FixedUpdate()
    {
        Pause_Button.SetActive(triva_finished);
        if (triva_finished == false && triva_started == false)
        {
            triva_started = true;
            Triva_Go();
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
        next_question();
    }

    public void next_question()
    {
        Question_Text.SetText(Quiz_List[0].Question_text);
        answer1_text.SetText(Quiz_List[0].Answers[0].Answer_text);
        answer2_text.SetText(Quiz_List[0].Answers[1].Answer_text);
        answer3_text.SetText(Quiz_List[0].Answers[2].Answer_text);
        Question_List.Add(Quiz_List[0]);
        Quiz_List.RemoveAt(0);
    }

    //EventSystem.current.currentSelectedGameObject.name
}
