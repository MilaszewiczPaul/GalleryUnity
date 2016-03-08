using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour {
	public AudioClip doorSwishClip;
	private Animator anim;
	private GameObject player;
	private int count;

	void Awake(){
		anim = GetComponent<Animator> ();
		player=GameObject.FindGameObjectWithTag(Tags.player) ;
	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			count++;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject == player) {
			count = Mathf.Max (0, count - 1);
		}
	}

	void Update() {
	anim.SetBool ("Open", count > 0);
	}
}


