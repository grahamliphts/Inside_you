using UnityEngine;
using System.Collections;

public class collider_llert : MonoBehaviour {

	public string perception;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == perception) {
			Debug.Log ("J'ai trouve de la bouffe !!!!");
			other.GetComponent<Ranger_script>().showPvParent(perception);
		}
	}
}