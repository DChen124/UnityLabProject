using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreKeeper : MonoBehaviour
{
    [SerializeField] int score = 100;
    [SerializeField] TMP_Text scoreText;

    public const int PointsLost = 1;
    public const int ScoreLowest = 0;


    // Start is called before the first frame update
    void Start()
    {
        DisplayScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MinusPoints(int points)
    {
        score -= points;
        DisplayScore();

    }

    public void MinusPoints()
    {
        MinusPoints(PointsLost);
    }

    private void DisplayScore()
    {
        scoreText.SetText("score: " + score);
    }
}
