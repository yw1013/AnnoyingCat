using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    private Text scoreText;
    public int score;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        score = 0;
        updateScore();
	}
	
    public void addScore(int newScore) {
        score += newScore;
        updateScore();
    }

    void updateScore() {
        scoreText.text = "Score: " + score;
    }

    public int getScore() {
        return score;
    }
}
