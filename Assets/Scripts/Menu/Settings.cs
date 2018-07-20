using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	public AudioMixer audioMixer;
	public Slider volumeSlider;

	void Start() {
		GameObject temp = GameObject.Find("VolumeSlider");
		if (temp != null) {
			volumeSlider = temp.GetComponent<Slider> ();
			if (volumeSlider != null) {
				float masterVolume = 0f;
//				bool result =  audioMixer.GetFloat("volume", out value);
//				if(result){
//					Debug.LogError (value);
//					volumeSlider.normalizedValue = value;
//				}else{
//					volumeSlider.normalizedValue = 0f;
//				}

				audioMixer.GetFloat ("volume", out masterVolume);
				volumeSlider.value = masterVolume;
			}
		}
	}


	public void SetVolume (float volume) {
		audioMixer.SetFloat ("volume", volume);		
	}

	public float GetVolume(){
		float value;
		bool result =  audioMixer.GetFloat("volume", out value);
		if(result){
			return value;
		}else{
			return 0f;
		}
	}
}
