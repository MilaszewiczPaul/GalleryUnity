using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class General : MonoBehaviour {
	

	public Text mytext;
	private GameObject player;
	private GameObject panel;


	void Awake(){
		

		player=GameObject.FindGameObjectWithTag(Tags.player) ;
		panel = GameObject.Find ("Panel");
		panel.gameObject.SetActive (false);
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			panel.gameObject.SetActive (true);
			mytext.text = "Project Information:\n"+"Project was made by undergraduate student Pavlos Milaszewicz as his\nfinal year thesis, " +
				"under the supervision of professor Dimitrios Varoutas.\n";
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			panel.gameObject.SetActive (false);
			mytext.text = "";
		}
	}
}
