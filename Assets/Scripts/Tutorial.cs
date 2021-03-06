﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

	public TimeSlider timeSlider;

	Animator anim;

	void Awake() {
		anim = GetComponent<Animator>();
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	void Start() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
		
	void Update() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		if (timeSlider.time <= 0.0) {
			anim.SetTrigger("GameOver");
			GameObject.Find("Player_Cat").GetComponent<CatControl>().enabled = false;
			GameObject.Find("Player_Cat").GetComponent<Animator>().enabled = false;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
