using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer_Bool : MonoBehaviour
{
    public bool Is_correct;
    public List<GameObject> Other_Buttons;
    public NEW_Multipul_choice_quiz scorecard;
    public float timer = 0.0f;

    public void Question_answer()
    {
        if (Is_correct == true)
        {
            gameObject.GetComponent<Image>().color = Color.green;
            scorecard.score++;
        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.red;
            for (int i = 0; i < Other_Buttons.Count; i++)
            {
                if (Other_Buttons[i].GetComponent<Answer_Bool>().Is_correct)
                {
                    Other_Buttons[i].GetComponent<Image>().color = Color.green;
                }
            }
        }
        gameObject.GetComponent<Button>().interactable = false;
        for (int i = 0; i < Other_Buttons.Count; i++)
        {
            Other_Buttons[i].GetComponent<Button>().interactable = false;
        }
    }

    private void FixedUpdate()
    {
        if (gameObject.GetComponent<Button>().interactable == true)
        {
            timer = 0.0f;
        }
        if (gameObject.GetComponent<Button>().interactable == false)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 2.0f)
        {
            gameObject.GetComponent<Button>().interactable = true;
            GameObject.FindObjectOfType<NEW_Multipul_choice_quiz>().next_question();
        }
    }
}
