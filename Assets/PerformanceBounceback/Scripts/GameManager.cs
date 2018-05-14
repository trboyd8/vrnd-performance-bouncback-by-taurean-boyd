using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int score = 0;
    public Score ScoreBoardOne;
    public Score ScoreBoardTwo;

    public void IncrementScore()
    {
        score++;
        ScoreBoardOne.UpdateScore(score);
        ScoreBoardTwo.UpdateScore(score);
    }
}
