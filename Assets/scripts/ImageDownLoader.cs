using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections;

public class ImageDownLoader : MonoBehaviour {
	public sculptures otherscript;

	void Awake () {
		StartCoroutine("Change");
	}


	IEnumerator  Change() {
		int i = 0;

		//!!!!!must put all this in a while so that you can change image EVERY time you enter the trigger zone
		while (i == 0) {
			while (otherscript.change == false) {
				yield return null;
			}
			#if UNITY_EDITOR
			if (EditorUtility.DisplayDialog ("Select new image?", "Do you want to select a new image?", "Yes", "No")) {
				string path = EditorUtility.OpenFilePanel ("Overwrite with jpeg", "","jpeg");
				if (path.Length != 0) {
					WWW www = new WWW ("file:///" + path);
					yield return www;
					Texture2D texture = www.texture;
					this.GetComponent<Renderer> ().material.mainTexture = texture;
				}
			}
			while (otherscript.change == true) {
				yield return null;
			}
			#endif
		}
	}

	

}
