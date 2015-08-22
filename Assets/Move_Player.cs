using UnityEngine;
using System.Collections;

public class Move_Player : MonoBehaviour {

	public int moveSpeed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
			var targetPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//targetPos.z = targetPos.y;
			transform.position = Vector3.MoveTowards (transform.position, targetPos, moveSpeed * Time.deltaTime);
		}
	}
}
