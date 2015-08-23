using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	[SerializeField] private int m_Pv = 10;
	[SerializeField] private float m_odeurRadius=0.5f;
	[SerializeField] private float m_bruitRadius=0.5f;
	private float m_scale = 1;
	
	private int m_vitamine = 0;
	private int m_magnesium = 0;
	private int m_fer = 0;
	private int m_graisse = 0;
	private int m_sucre = 0;

	//stats
	private int m_vitesseDeplacement = 0;
	private int m_vitesseAttaque = 0;
	private int m_resistance = 0;
	private int m_pv = 0;
	private int m_degat = 0;

	private string m_name ="default";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	IEnumerator ShowMe() {
		//m_scale = 0f;
		while (m_scale < 1f) {
			transform.localScale = new Vector3(m_scale,m_scale,m_scale);
			yield return new WaitForSeconds(0.001f);
			m_scale += 0.1f;
		}
	}
	
	public void set_name(string NewName)
	{
		m_name = NewName;
	}
	public string get_name()
	{
		return m_name;
	}
	
	public int getPV()
	{
		return m_Pv;
	}
	public float getOdeurRadius()
	{
		return m_odeurRadius;
	}
	public float getBruitRadius()
	{
		return m_bruitRadius;
	}
	public void setVisibilityOn()
	{
		//Debug.Log ("Je suis vue");
		
	}
	public void setOdeurOn()
	{
		//Debug.Log ("Je suis senti");
	}
	public void setBruitOn()
	{
		//Debug.Log ("Je suis entendu");
		if(m_scale < 1f) 
			StartCoroutine ("ShowMe");
	}
	public void setPv(int newPv)
	{
		m_Pv = newPv;
	}
	public void setName(string newName)
	{
		name = newName;
	}
	public void setOdeurRange(float newRadius)
	{
		m_odeurRadius = newRadius;
	}
	public void setBruitRange(float newRadius)
	{
		m_bruitRadius = newRadius;
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
	public int getDegat () {
		return m_degat;
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
	public void setDegat (int newDegat) {
		m_pv=newDegat;
	}
}
