using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static float playedTime = 0f;
	bool paused = false;
	public static Text score = null;
	public static float LastNilai = 0;
	public static float HighNilai = 4.0f;

	// Use this for initialization
	void Start () {
		playedTime = 0f;
		score = this.gameObject.GetComponent<Text>();
		score.text = "IP: ";
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("haha");
		if (paused != true) {
			playedTime += Mathf.Round(Time.deltaTime * 100f) / 10000f;
			float tmp = 4.0f - playedTime;
			score.text = "IP: " + tmp;
			LastNilai = tmp;
		}
	}

	public void pauseGame() {
		paused = true;
	}

	public void lanjutGame() {
		paused = false;
	}
}
