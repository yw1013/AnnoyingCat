using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	public Timer timerManager;

	Animator anim;

	void Awake() {
		anim = GetComponent<Animator>();
	}
		
	void Update() {
		if (timerManager.timer <= 0) {
			anim.SetTrigger("GameOver");
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			GameObject.Find("Player_Cat").GetComponent<CatControl>().enabled = false;
			GameObject.Find("Player_Cat").GetComponent<Animator>().enabled = false;
		}
	}
}
