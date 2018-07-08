using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour {

	public void Instruction() {
		Time.timeScale = 0f;
		Debug.LogError ("How to Play");
//		SceneManager.LoadScene ("demo");
	}

}
