using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour {

	public void StartGame() {
		Time.timeScale = 1f;
		Debug.LogError ("Game Start");
//		SceneManager.LoadScene ("Game");
	}

}
