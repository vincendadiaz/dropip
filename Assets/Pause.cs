using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject scorePanel = GameObject.Find ("ScoreInsidePanel");
//			if (Score.LastNilai < Score.HighNilai) {
//				Score.HighNilai = Score.LastNilai;
//			}
		scorePanel.GetComponent<Text>().text = "IP: " + Score.LastNilai.ToString("F2") +"\nLowest IP: " + Score.HighNilai.ToString("F2");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape))
		{
			if (Application.platform == RuntimePlatform.Android)
			{
				Application.Quit();
			}
		}
	}

	public void reloadGame()
	{			
		// ... pause briefly
		//yield return new WaitForSeconds(2);
		// ... and then reload the level.
		Application.LoadLevel (1);
	}
	
	public void exitGame(){
		Application.LoadLevel (0);
	}

	private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
	private const string TWEET_LANGUAGE = "en"; 
	string textToDisplay = "Coy, IP gw " + Score.HighNilai.ToString("F2") + " di game Drop IP! " + "http://bit.ly/androiddropip";

	public void ShareToTwitter ()
	{
		Application.OpenURL(TWITTER_ADDRESS +
		                    "?text=" + WWW.EscapeURL(textToDisplay) +
		                    "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
	}
}
