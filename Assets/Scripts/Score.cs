using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    private int totalScore;

    private Text scoreText;

	// Use this for initialization
	void Start () {
        totalScore = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + totalScore;
	}

    public void AddScore(int score)
    {
        totalScore += score;
        scoreText.text = "Score: " + totalScore;
    }
}
