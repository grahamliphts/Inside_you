using UnityEngine;
using System.Collections;

public class InterfaceManagement : MonoBehaviour {

	[SerializeField] private RessourceManager m_fer;
	[SerializeField] private RessourceManager m_vitamine;
	[SerializeField] private RessourceManager m_sucre;
	[SerializeField] private RessourceManager m_graisse;
	[SerializeField] private RessourceManager m_adrenaline;
	[SerializeField] private RessourceManager m_peur;
	[SerializeField] private RessourceManager m_temperature;

	[SerializeField] private Player_main_script m_player;


	// Use this for initialization
	void Start () {

		                   
	
	}
	
	// Update is called once per frame
	void Update () {


		m_fer.updateValue (m_player.getFer ());
		m_vitamine.updateValue (m_player.getVitamine ());
		m_sucre.updateValue (m_player.getSucre ());
		m_graisse.updateValue (m_player.getGraisse ());
		m_adrenaline.updateValue (m_player.getAdrenaline ());
		m_peur.updateValue (m_player.getPeur ());
		m_temperature.updateValue (m_player.getTemperature ());
	}
}
