using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	public string levelToLoad;
	public float timer = 10f;
	private Text timerSeconds;

	void Start() {
		timerSeconds = GetComponent<Text> ();
	}

	void Update() {
		timer -= Time.deltaTime;
		timerSeconds.text = "Timer: " + timer.ToString ("f2");
		if (timer <= 0.00) {
			timerSeconds.text = "Timer: 0.00";
		}
	}
}
