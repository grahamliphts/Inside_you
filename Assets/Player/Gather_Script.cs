using UnityEngine;
using System.Collections;

public class Gather_Script : MonoBehaviour {

	[SerializeField] Player_main_script m_player;

	[SerializeField] private int m_x1,m_x2,m_y1,m_y2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.name == "bouffe") {
			encounter m_encounter =  other.GetComponent<encounter>();
			m_player.setVitamine(m_player.getVitamine() + m_encounter.getVitamine());
			m_player.setFer(m_player.getFer() + m_encounter.getFer());
			m_player.setSucre(m_player.getSucre() + m_encounter.getSucre());
			m_player.setGraisse(m_player.getGraisse() + m_encounter.getGraisse());
			m_player.setMagnesium(m_player.getMagnesium() + m_encounter.getMagnesium());

			Debug.Log ("Ce " + m_encounter.get_name() + " était vachement bon");
			other.transform.position = new Vector3(Random.Range(m_x1,m_x2),0f,Random.Range (m_y1,m_y2));
		}
	}
}
