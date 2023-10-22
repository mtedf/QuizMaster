using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float fltTimeToCompleteQuestion = 30f;
    [SerializeField] float fltTimeToShowCorrectAnswer = 5f;

    public bool loadNextQuestion;
    
    public bool isAnsweringQuestion = false;
    public float fltFillFraction;
    float fltTimerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        fltTimerValue = 0;
    }

    void UpdateTimer()
    {
        fltTimerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if (fltTimerValue > 0)
            {
                fltFillFraction = fltTimerValue / fltTimeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                fltTimerValue = fltTimeToShowCorrectAnswer;
            }
            
        }
        else
        {
            if(fltTimerValue > 0) 
            {
                fltFillFraction = fltTimerValue / fltTimeToShowCorrectAnswer;

            }
            else
            {
                isAnsweringQuestion = true;
                fltTimerValue = fltTimeToCompleteQuestion;
            }
        }

        
        Debug.Log(isAnsweringQuestion + ": " + fltTimerValue + " = "+ fltFillFraction);
        

    }
}
