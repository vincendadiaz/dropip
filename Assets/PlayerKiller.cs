using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerKiller : MonoBehaviour {


	GameObject spawner = GameObject.Find("Spawn2");
	GameObject pauseScore = GameObject.Find("CanvasScore");


	// Use this for initialization
	void Start () {

		pauseScore = GameObject.Find("CanvasScore");
		spawner = GameObject.Find("Spawn2");

		//gameOver.active = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			GameObject[] gameObjects =  GameObject.FindGameObjectsWithTag ("Obs");
			for(var i = 0 ; i < gameObjects.Length ; i ++){
				Destroy(gameObjects[i]);
			}
			// StartCoroutine("ReloadGame");
			Application.LoadLevel(2);

//			pauseScore.SetActive(false);
//			spawner.SetActive(false);
//			gameOver.SetActive(true);
//			//gameOver.renderer.enabled = true;
//			//gameOver.active = true;
//
//			GameObject scorePanel = GameObject.Find ("ScoreInsidePanel");
			if (Score.LastNilai < Score.HighNilai) {
				Score.HighNilai = Score.LastNilai;
			}
//			scorePanel.GetComponent<Text>().text = "IP: " + Score.LastNilai.ToString("F2") +"\nLowest IP: " + Score.HighNilai.ToString("F2");
		}
	}
}
