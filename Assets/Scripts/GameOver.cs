using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public Timer timerManager;


	Animator anim;


	void Awake() {
		anim = GetComponent<Animator>();
	}


	void Update() {
		if (timerManager.timer <= 0) {
			anim.SetTrigger("GameOver");
		}
	}
}

