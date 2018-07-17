using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	private static BGMScript instance = null;
	public static BGMScript Instance {
		get {
			return instance;
		}
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
}
