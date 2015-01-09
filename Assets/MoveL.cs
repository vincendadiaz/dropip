using UnityEngine;
using System.Collections;

public class MoveL : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			
			if (touch.phase == TouchPhase.Stationary)
			{ 
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
				RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
				if (hit) {
					Debug.Log (hit.collider.gameObject.name);
					if (hit.collider.gameObject.name == "JoystickL") {
						if (player != null)
						{
							player.rigidbody2D.AddForce (-Vector2.right * 15f, ForceMode2D.Force);
						}
					}
				}
			}
		}
		
		
		if (Application.platform == RuntimePlatform.WindowsEditor)
		{
			if (Input.GetMouseButton(0))
			{
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
				if (hit) {
					Debug.Log (hit.collider.gameObject.name);
					if (hit.collider.gameObject.name == "JoystickL") {
						if (player != null)
						{
							player.rigidbody2D.AddForce (-Vector2.right * 15f, ForceMode2D.Force);
						}
					}
				}
			}
		}
	}
}
