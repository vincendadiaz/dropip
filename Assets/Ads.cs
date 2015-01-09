using UnityEngine;
using System.Collections;

public class Ads : MonoBehaviour {

	VservPlugin vservePlugin;

	// Use this for initialization
	void Start () {
		vservePlugin = new VservPlugin ();
		vservePlugin.RenderAd ("147badb8", 2);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
