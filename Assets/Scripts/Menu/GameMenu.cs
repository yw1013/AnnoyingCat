using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {
	Animator anim;

	void Awake() {
		anim = GetComponent<Animator>();
	}

	void Start () {
		Screen.SetResolution (1920, 1080, true);
	}

	public void Tutorial() {
		Time.timeScale = 1f;
		Debug.LogError ("Game Tutorial");
		SceneManager.LoadScene ("Level1Tutorial");
	}
	public void StartGame() {
		Time.timeScale = 1f;
		Debug.LogError ("Game Start");
		SceneManager.LoadScene ("Level1");
	}

	public void QuitGame () {
		Debug.LogError ("Quit Game");
		Application.Quit ();
	}

	public void BackToMenu() {
		Debug.LogError ("Back To Menu");
		SceneManager.LoadScene ("Level1GameMenuScene");
	}
}
