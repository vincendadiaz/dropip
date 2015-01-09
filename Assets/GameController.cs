using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void rate() {
		Application.OpenURL("market://details?id=com.sciters.dropip");
	}


	public void play() {
		Application.LoadLevel (1);
	}
}
