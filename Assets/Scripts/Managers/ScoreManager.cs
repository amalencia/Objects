using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int highestScore;
    [SerializeField] private int totalScore;
    public static ScoreManager singleton;

    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();

    private void Awake()
    {
        singleton = this;
        highestScore = PlayerPrefs.GetInt("HSCORE");  //retrieving save file with name HSCORE
    }

    public void RegisterHighScore()
    {
        if (totalScore > highestScore)
        {
            PlayerPrefs.SetInt("HSCORE", totalScore);
            highestScore = totalScore;
        }
        
    }
    public void IncreaseScore()
    {
        totalScore += 1;
    }

}
