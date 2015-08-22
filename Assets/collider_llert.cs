using UnityEngine;
using System.Collections;

public class collider_llert : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Capsule (4)")
			Debug.Log ("coucou");
	}
}