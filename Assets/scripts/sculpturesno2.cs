using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class sculpturesno2 : MonoBehaviour {

	public TextAsset textFile;
	public Text mytext;
	private GameObject player;
	private GameObject panel;

	void Awake(){


		player=GameObject.FindGameObjectWithTag(Tags.player) ;
		panel = GameObject.Find ("Panel");

	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			string text = textFile.text;
			Debug.Log ("player entered the sculpture trigger zone");
			panel.gameObject.SetActive (true);
			mytext.text = "king\n"+text;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			Debug.Log ("player exited the sculpture trigger zone");
			panel.gameObject.SetActive (false);
			mytext.text = "";
		}
	}
}

/*public class sculpturesno2 : MonoBehaviour {

	//public WWW w;
	public Text mytext;
	private GameObject player;
	private GameObject panel;
	private string text2;
	void Awake(){


		player=GameObject.FindGameObjectWithTag(Tags.player) ;
		panel = GameObject.Find ("Panel");

	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			//w = new WWW ("file:///Users/Pavlos/Desktop/test2.txt");
			StreamReader inp_stm=new StreamReader("/Users/Pavlos/Desktop/test2.txt");

			while (!inp_stm.EndOfStream) {
				string inp_ln = inp_stm.ReadLine ();
				text2 += inp_ln;
				text2 += "\n";
				mytext.text = "sculptures\n"+inp_ln;
			}
			inp_stm.Close ();
			Debug.Log ("player entered the sculpture trigger zone");

			panel.gameObject.SetActive (true);
			mytext.text = "hey"+text2;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			Debug.Log ("player exited the sculpture trigger zone");
			panel.gameObject.SetActive (false);
			mytext.text = "";
		}
	}
}*/
