using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	
	public GameObject pausePanel;
	public bool isPaused;
	public bool muted;

	void Start() {
		isPaused = false;
	}


	void Update(){
		if (isPaused) {
			PauseGame (true);
		} 
		else {
			PauseGame (false);
		}

		if (Input.GetButtonDown ("Cancel")) {
			SwitchPause ();
		}

		if (muted) {
			AudioListener.volume = 0;
		} 
		else {
			AudioListener.volume = 1;
		}
	}


	void PauseGame(bool state){
		if (state) {
			Time.timeScale = 0.0f;  
		} 
		else {
			Time.timeScale = 1.0f;	
		}
		pausePanel.SetActive (state);
	}


	public void SwitchPause() {
		if (isPaused) {
			isPaused = false;
		} 
		else {
			isPaused = true;
		}
	}

	public void MainMenu() {
		Application.LoadLevel (0);
	}

	public void Quit(){
		Application.Quit ();
	}

	public void Mute(){
		muted = !muted;
	}
}
