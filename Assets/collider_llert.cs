using UnityEngine;
using System.Collections;

public class collider_llert : MonoBehaviour {

	public string perception;
	[SerializeField] private Player_main_script m_playerScript;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == perception) {
			Debug.Log ("J'ai trouve de la bouffe !!!!");
			other.GetComponent<Ranger_script>().showParent(perception);
			//m_playerScript.set
			m_playerScript.setVitamine(m_playerScript.getVitamine() +  1) ;
			//Debug.Log(m_playerScript.getVitamine());
		}
	}
}