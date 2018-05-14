using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = this.GetComponentInChildren<Text>();
	}
	
    public void UpdateScore(int score)
    {
        text.text = "Score: " + score.ToString();
    }
}
