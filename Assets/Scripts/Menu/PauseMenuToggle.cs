using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class PauseMenuToggle : MonoBehaviour {

	private CanvasGroup canvasGroup;

	void Awake () {
		if (canvasGroup == null) {
//			Debug.LogError ("can't find CanvasGroup ");
		}
		canvasGroup = GetComponent<CanvasGroup> ();

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (canvasGroup.interactable) {
				Time.timeScale = 1f;
				canvasGroup.interactable = false; 
				canvasGroup.blocksRaycasts = false; 
				canvasGroup.alpha = 0f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
			} else {
				Time.timeScale = 0f;
				canvasGroup.interactable = true; 
				canvasGroup.blocksRaycasts = true; 
				canvasGroup.alpha = 1f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
			} 
		}

	}
}
