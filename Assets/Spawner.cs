using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	bool isSpawning = false;
	public float minTime = 1.0f;
	public float maxTime = 4.0f;
	public GameObject[] bricks;		// Array of prefabs.

	// Use this for initialization
	void Start () {
	}

	IEnumerator SpawnObject(int index, float seconds)
	{
		Debug.Log ("Waiting for " + seconds + " seconds");
		
		yield return new WaitForSeconds(seconds);
		int pos = Random.Range (1, 3);
		float loc = 0f;
		if (pos == 1) {
			loc = -1.5f;
		} else if (pos == 2) {
			loc = 0f;
		} else if (pos == 3) {
			loc = 1.5f;
		}
		Instantiate(bricks[index], new Vector3(loc,-4.5f, 0f), transform.rotation);
		
		//We've spawned, so now we could start another spawn     
		isSpawning = false;
	}
	
	void Update () 
	{
		//We only want to spawn one at a time, so make sure we're not already making that call
		if(! isSpawning)
		{
			isSpawning = true; //Yep, we're going to spawn
			int enemyIndex = Random.Range(0, bricks.Length);
			StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
		}
	}
	
	void Spawn () {
		int enemyIndex = Random.Range(0, bricks.Length);
		Instantiate(bricks[enemyIndex], transform.position, transform.rotation);
	}
}