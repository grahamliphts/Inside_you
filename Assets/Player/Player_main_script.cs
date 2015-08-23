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
	private int m_resistTemperatures = 0;
	private int m_courage = 0;
	private int m_prodAdrenaline = 0;

	//consommation
	private int m_consoFer = 0;
	private int m_consoMagnesium = 0;
	private int m_consoVitamine = 0;
	private int m_consoSucre = 0;
	private int m_consoGraisse = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int getFer () {
		return m_fer;
	}
	int getMagnesium () {
		return m_magnesium;
	}
	int getVitamine () {
		return m_vitamine;
	}
	int getSucre () {
		return m_sucre;
	}
	int getGraisse () {
		return m_graisse;
	}
	int getAdrenaline () {
		return m_adrenaline;
	}
	int getTemperature () {
		return m_temperature;
	}
	int getVitesseDeplacement () {
		return m_vitesseDeplacement;
	}
	int getVitesseAttaque () {
		return m_vitesseAttaque;
	}
	int getResistance () {
		return m_resistance;
	}
	int getPv () {
		return m_pv;
	}
	int getResistTemperatures () {
		return m_resistTemperatures;
	}
	int getCourage () {
		return m_courage;
	}
	int getProdAdrenaline () {
		return m_prodAdrenaline;
	}
	int getConsoFer () {
		return m_consoFer;
	}
	int getConsoMagnesium () {
		return m_consoMagnesium;
	}
	int getConsoVitamine () {
		return m_consoVitamine;
	}
	int getConsoGraisse () {
		return m_consoGraisse;
	}
	int getConsoSucre () {
		return m_consoSucre;
	}


	void setFer (int newFer) {
		m_fer=newFer;
	}
	void setMagnesium (int newMagnesium) {
		m_magnesium=newMagnesium;
	}
	void setVitamine (int newVitamine) {
		m_vitamine=newVitamine;
	}
	void setSucre (int newSucre) {
		m_sucre=newSucre;
	}
	void setGraisse (int newGraisse) {
		m_graisse=newGraisse;
	}
	void setAdrenaline (int newAdrenaline) {
		m_adrenaline=newAdrenaline;
	}
	void setTemperature (int newTemperature) {
		m_temperature=newTemperature;
	}
	void setVitesseDeplacement (int newVitesseDeplacement) {
		m_vitesseDeplacement=newVitesseDeplacement;
	}
	void setVitesseAttaque (int newVitesseAttaque) {
		m_vitesseAttaque=newVitesseAttaque;
	}
	void setResistance (int newResistance) {
		m_resistance=newResistance;
	}
	void setPv (int newPv) {
		m_pv=newPv;
	}
	void setResistTemperatures (int newResistTemp) {
		m_resistTemperatures=newResistTemp;
	}
	void setCourage (int newCourage) {
		m_courage=newCourage;
	}
	void setProdAdrenaline (int newProdAdrenaline) {
		m_prodAdrenaline=newProdAdrenaline;
	}
	void setConsoFer (int newConsoFer) {
		m_consoFer=newConsoFer;
	}
	void setConsoMagnesium (int newConsoMagne) {
		m_consoMagnesium=newConsoMagne;
	}
	void setConsoVitamine (int newConsoVita) {
		m_consoVitamine=newConsoVita;
	}
	void setConsoGraisse (int newConsoGraisse) {
		m_consoGraisse=newConsoGraisse;
	}
	void setConsoSucre (int newConsoSucre) {
		m_consoSucre=newConsoSucre;
	}
}
