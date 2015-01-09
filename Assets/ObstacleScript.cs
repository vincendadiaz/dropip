using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	public static bool pause = false;

	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (pause != true) {
				this.gameObject.transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime);
		}
//		foreach (Touch touch in Input.touches) {
//			
//			if (touch.phase == TouchPhase.Stationary)
//			{ 
//				Ray ray = Camera.main.ScreenPointToRay(touch.position);
//				RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
//				if (hit) {
//					Debug.Log (hit.collider.gameObject.name);
//					if (hit.collider.gameObject.tag == "Obs") {
//						Destroy(this.gameObject);
//					}
//				}
//			}
//		}
//		
//		
//		if (Application.platform == RuntimePlatform.WindowsEditor)
//		{
//			if (Input.GetMouseButton(0))
//			{
//				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//				RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
//				if (hit) {
//					Debug.Log (hit.collider.gameObject.name);
//					if (hit.collider.gameObject.tag == "Obs") {
//						Destroy(this.gameObject);
//					}
//				}
//			}
//		}
	}

	public void nyetop() {

		GameObject[] bricks = GameObject.FindGameObjectsWithTag("Obs");

		foreach (GameObject brick in bricks) {
			brick.transform.Translate(new Vector3(0,0,0) * Time.deltaTime);

		}
		pause = true;
	}

	public void lanjut() {
		
		GameObject[] bricks = GameObject.FindGameObjectsWithTag("Obs");
		
		foreach (GameObject brick in bricks) {
			brick.transform.Translate(new Vector3(0,1,0) * Time.deltaTime);
			
		}
		pause = false;
	}
}
