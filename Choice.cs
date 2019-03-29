using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject Question;
    public GameObject canvasQuestion;

    public Button Choice01;
    public Button Choice02;
    public Button Choice03;


    public int ChoiceMode;

    public GameObject Candle1_f1;

    public GameObject Candle2_f1;

    public GameObject Candle3_f1;

    public GameObject Candle4_f1;
    
    private int question_counter = 0;

    void Start()
    {
        
        Choice01.onClick.AddListener(() => { AfterClick(Choice01); });
        Choice02.onClick.AddListener(() => { AfterClick(Choice02); });
        Choice03.onClick.AddListener(() => { AfterClick(Choice03); });
        Question.GetComponent<Text>().text = "Çimen ne renktir?";
        Choice01.GetComponentInChildren<Text>().text = "Yeşil";
        Choice02.GetComponentInChildren<Text>().text = "Sarı";
        Choice03.GetComponentInChildren<Text>().text = "Mavi";
        Choice01.tag = "Q_true";
        Choice02.tag = "Q_false";
        Choice03.tag = "Q_false";
    }



    public void AfterClick(Button sender)
    {


        if (question_counter == 0)
        {
            Question.GetComponent<Text>().text = "Question 2";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
            Choice01.tag = "Q_true";
            Choice02.tag = "Q_false";
            Choice03.tag = "Q_false";
            if (sender != null && !sender.CompareTag("Q_true"))
            {
                Candle1_f1.SetActive(false);
            }

        }

        else if (question_counter == 1)
        {
            Question.GetComponent<Text>().text = "Question 3";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
            Choice01.tag = "Q_true";
            Choice02.tag = "Q_false";
            Choice03.tag = "Q_false";
            if (sender != null && !sender.CompareTag("Q_true"))
            {
                Candle2_f1.SetActive(false);
            }
        }

        else if (question_counter == 2)
        {
            Question.GetComponent<Text>().text = "Question 4";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
            Choice01.tag = "Q_true";
            Choice02.tag = "Q_false";
            Choice03.tag = "Q_false";
            if (sender != null && !sender.CompareTag("Q_true"))
            {
                Candle3_f1.SetActive(false);
            }
        }

        else if (question_counter == 3)
        {
            
            if (sender != null && !sender.CompareTag("Q_true"))
            {
                Candle4_f1.SetActive(false);
            }
            canvasQuestion.SetActive(false);
        }       
        question_counter++;

    }
    public void ChoiceOption01()
    {
        // Question.GetComponent<Text>().text = "First Choice";
        ChoiceMode = 1;
    }
    public void ChoiceOption02()
    {
        //Question.GetComponent<Text>().text = "Second Choice";
        ChoiceMode = 2;
    }
    public void ChoiceOption03()
    {
        // Question.GetComponent<Text>().text = "Third Choice";
        ChoiceMode = 3;
    }



}
