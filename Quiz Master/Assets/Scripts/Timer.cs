using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float fltTimeToCompleteQuestion = 30f;
    [SerializeField] float fltTimeToShowCorrectAnswer = 5f;
    
    public bool isAnsweringQuestion = false;
    
    float fltTimerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        fltTimerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(fltTimerValue <= 0)
            {
                isAnsweringQuestion=false;
                fltTimerValue = fltTimeToShowCorrectAnswer;
            }
        }
        else
        {
            if(fltTimerValue <= 0) 
            {
                isAnsweringQuestion = true;
                fltTimerValue = fltTimeToCompleteQuestion;

            }
        }

        
        Debug.Log(fltTimerValue);
        

    }
}
