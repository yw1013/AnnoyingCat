using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public Timer timerManager;
    public ScoreManager scoreManager;
    private int finalScore;
    public HighScoreKeeper highScore;


	Animator anim;


	void Awake() {
		anim = GetComponent<Animator>();
	}


	void Update() {
		if (timerManager.timer <= 0) {
			anim.SetTrigger("GameOver");
			GameObject.Find("Player_Cat").GetComponent<CatControl>().enabled = false;
			GameObject.Find("Player_Cat").GetComponent<Animator>().enabled = false;
            finalScore = scoreManager.getScore();
            highScore.updateScore();
		}
	}

    public int getLastestScore() {
        return finalScore;
    }
}