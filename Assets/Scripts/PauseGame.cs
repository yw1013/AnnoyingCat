using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	public void gamePause() {
		Time.timeScale = 0f;
		Debug.LogError ("Pause Game");
	}

}
