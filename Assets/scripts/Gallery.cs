using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gallery : MonoBehaviour {


	public Text mytext;
	private GameObject player;
	private GameObject panel;

	void Awake(){


		player=GameObject.FindGameObjectWithTag(Tags.player) ;
		panel = GameObject.Find ("Panel");
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			panel.gameObject.SetActive (true);
			mytext.text = "Dynamic Gallery Project\n"+"Welcome to my gallery, press esc for the pause menu from which \nyou can switch of the music, go to the main menu, or quit the game.";
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			panel.gameObject.SetActive (false);
			mytext.text = "";
		}
	}
}
