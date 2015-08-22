using UnityEngine;
using System.Collections;

public class collider_llert : MonoBehaviour {

	public string Perception;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == Perception) {
			Debug.Log ("J'ai trouve e la bouffe !!!!");
			other.GetComponent<Ranger_script>().showPvParent();
		}
	}
}