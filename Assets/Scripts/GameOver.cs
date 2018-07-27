using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public TimeSlider timeSlider;
    public ScoreManager scoreManager;
    private int finalScore;
    public HighScoreKeeper highScore;


	Animator anim;


	void Awake() {
		anim = GetComponent<Animator>();
	}


	void Update() {
		if (timeSlider.time <= 0) {
			anim.SetTrigger("GameOver");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
			GameObject.Find("Player_Cat").GetComponent<CatControl>().enabled = false;
			GameObject.Find("Player_Cat").GetComponent<Animator>().enabled = false;
			GameObject.Find ("Level1 InGameMenuCanvas").GetComponent<PauseMenuToggle> ().enabled = false;
			GameObject.Find ("HUDCanvas").GetComponent<GraphicRaycaster> ().enabled = true;

            finalScore = scoreManager.getScore();
            highScore.updateScore();
		}
	}

    public int getLastestScore() {
        return finalScore;
    }
}