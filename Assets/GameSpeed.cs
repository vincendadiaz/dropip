using UnityEngine;
using System.Collections;

public class GameSpeed : MonoBehaviour {

	float playedTime = 0f;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1F;
	}
	
	// Update is called once per frame
	void Update () {
		playedTime += Time.deltaTime;
		if (playedTime > 20) {
			Time.timeScale = 1.2F;
		}
		if (playedTime > 30) {
			Time.timeScale = 1.4F;
		}
		if (playedTime > 40) {
			Time.timeScale = 1.6F;
		}
		if (playedTime > 50) {
			Time.timeScale = 1.8F;
		}
		if (playedTime > 60) {
			Time.timeScale = 2.0F;
		}

	}
}
