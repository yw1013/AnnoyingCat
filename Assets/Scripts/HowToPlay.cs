using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class HowToPlay : MonoBehaviour {

	private CanvasGroup canvasGroup;

	void Awake () {
		if (canvasGroup == null) {
			Debug.LogError ("can't find CanvasGroup ");
		}
		canvasGroup = GetComponent<CanvasGroup> ();

	}

	public void Instruction() {
		Time.timeScale = 0f;
		Debug.LogError ("How to Play");
	}
		
}
