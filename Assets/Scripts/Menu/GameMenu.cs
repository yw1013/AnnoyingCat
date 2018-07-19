using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

	void Start () {
		Screen.SetResolution (1920, 1080, true);
	}

	public void StartGame() {
		Time.timeScale = 1f;
		Debug.LogError ("Game Start");
		SceneManager.LoadScene ("demoScene");
	}

	public void QuitGame () {
		Debug.LogError ("Quit Game");
		Application.Quit ();
	}

	public void BackToMenu() {
		Debug.LogError ("Back To Menu");
		SceneManager.LoadScene ("GameMenuScene");
	}
}
