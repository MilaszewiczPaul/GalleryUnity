
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sculptures : MonoBehaviour {

	public GameObject panel;
	public TextAsset textFile;
	public Text mytext;
	private GameObject player;
	public bool change;


	void Awake(){
		player=GameObject.FindGameObjectWithTag(Tags.player) ;
		change = false;

	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			change = true;
			string text = textFile.text;
			panel.gameObject.SetActive (true);
			mytext.text = text;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			change = false;
			panel.gameObject.SetActive (false);
			mytext.text = "";
		}
	}




}