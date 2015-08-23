using UnityEngine;
using System.Collections;

public class Player_main_script : MonoBehaviour {
	//Ressources
	private int m_fer = 0;
	private int m_magnesium = 0;
	private int m_vitamine = 0;
	private int m_sucre = 0;
	private int m_graisse = 0;
	private int m_adrenaline = 0;
	private int m_temperature = 0;
	private int m_peur = 0;

	//stats
	private int m_vitesseDeplacement = 0;
	private int m_vitesseAttaque = 0;
	private int m_resistance = 0;
	private int m_pv = 0;
	private int m_degat = 0;
	private int m_resistTemperatures = 0;
	private int m_courage = 0;
	private int m_prodAdrenaline = 0;

	//consommation
	private int m_consoFer = 0;
	private int m_consoMagnesium = 0;
	private int m_consoVitamine = 0;
	private int m_consoSucre = 0;
	private int m_consoGraisse = 0;

	[SerializeField] private Light m_playerLight;
	[SerializeField] private SphereCollider m_vueCollider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		m_vueCollider.radius = m_playerLight.range;
	
	}

	public int getFer () {
		return m_fer;
	}
	public int getMagnesium () {
		return m_magnesium;
	}
	public int getVitamine () {
		return m_vitamine;
	}
	public int getSucre () {
		return m_sucre;
	}
	public int getGraisse () {
		return m_graisse;
	}
	public int getAdrenaline () {
		return m_adrenaline;
	}
	public int getTemperature () {
		return m_temperature;
	}
	public int getVitesseDeplacement () {
		return m_vitesseDeplacement;
	}
	public int getVitesseAttaque () {
		return m_vitesseAttaque;
	}
	public int getResistance () {
		return m_resistance;
	}
	public int getPv () {
		return m_pv;
	}
	public int getResistTemperatures () {
		return m_resistTemperatures;
	}
	public int getCourage () {
		return m_courage;
	}
	public int getProdAdrenaline () {
		return m_prodAdrenaline;
	}
	public int getConsoFer () {
		return m_consoFer;
	}
	public int getConsoMagnesium () {
		return m_consoMagnesium;
	}
	public int getConsoVitamine () {
		return m_consoVitamine;
	}
	public int getConsoGraisse () {
		return m_consoGraisse;
	}
	public int getConsoSucre () {
		return m_consoSucre;
	}

	public int getPeur()
	{
		return m_peur;
	}
	public int getDegat () {
		return m_degat;
	}


	public void setFer (int newFer) {
		m_fer=newFer;
	}
	public void setMagnesium (int newMagnesium) {
		m_magnesium=newMagnesium;
	}
	public void setVitamine (int newVitamine) {
		m_vitamine=newVitamine;
	}
	public void setSucre (int newSucre) {
		m_sucre=newSucre;
	}
	public void setGraisse (int newGraisse) {
		m_graisse=newGraisse;
	}
	public void setAdrenaline (int newAdrenaline) {
		m_adrenaline=newAdrenaline;
	}
	public void setTemperature (int newTemperature) {
		m_temperature=newTemperature;
	}
	public void setVitesseDeplacement (int newVitesseDeplacement) {
		m_vitesseDeplacement=newVitesseDeplacement;
	}
	public void setVitesseAttaque (int newVitesseAttaque) {
		m_vitesseAttaque=newVitesseAttaque;
	}
	public void setResistance (int newResistance) {
		m_resistance=newResistance;
	}
	public void setPv (int newPv) {
		m_pv=newPv;
	}
	public void setResistTemperatures (int newResistTemp) {
		m_resistTemperatures=newResistTemp;
	}
	public void setCourage (int newCourage) {
		m_courage=newCourage;
	}
	public void setProdAdrenaline (int newProdAdrenaline) {
		m_prodAdrenaline=newProdAdrenaline;
	}
	public void setConsoFer (int newConsoFer) {
		m_consoFer=newConsoFer;
	}
	public void setConsoMagnesium (int newConsoMagne) {
		m_consoMagnesium=newConsoMagne;
	}
	public void setConsoVitamine (int newConsoVita) {
		m_consoVitamine=newConsoVita;
	}
	public void setConsoGraisse (int newConsoGraisse) {
		m_consoGraisse=newConsoGraisse;
	}
	public void setConsoSucre (int newConsoSucre) {
		m_consoSucre=newConsoSucre;
	}
	public void setDegat (int newDegat) {
		m_pv=newDegat;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "vilain") {
		
			m_pv --;		
		}
	}
}
