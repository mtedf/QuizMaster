using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int intCorrectAnswers = 0;
    int intQuestionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return intCorrectAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        intCorrectAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return intQuestionsSeen;
    }

    public void IncrimentQuestionsSeen()
    {
        intQuestionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt( intCorrectAnswers / (float)intQuestionsSeen * 100);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
