using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreKeeper : MonoBehaviour {


    private Text scoreText;
    private GameOver gameOver; 

    private int score = 0;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
        score = gameOver.getLastestScore();
		
	}
	
    public void updateScore()
    {
        scoreText.text = "Game Over!!!\nYour Score: " + score;
    }
}
