using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	public Timer timerManager;

	Animator anim;

	void Awake() {
		anim = GetComponent<Animator>();
		Cursor.visible = true;
	}

	void Start() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
		
	void Update() {
		if (timerManager.timer <= 0) {
			anim.SetTrigger("GameOver");

			GameObject.Find("Player_Cat").GetComponent<CatControl>().enabled = false;
			GameObject.Find("Player_Cat").GetComponent<Animator>().enabled = false;
		}
	}
}
