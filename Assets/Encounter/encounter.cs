using UnityEngine;
using System.Collections;

public class encounter : MonoBehaviour {
	[SerializeField] private int m_Pv = 10;
	[SerializeField] private float m_odeurRadius=0.5f;
	[SerializeField] private float m_bruitRadius=0.5f;

	private float m_scale = 1;



	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (m_scale, m_scale, m_scale);

	
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
		Debug.Log ("Je suis vue");

	}
	public void setOdeurOn()
	{
		Debug.Log ("Je suis senti");
	}
	public void setBruitOn()
	{
		Debug.Log ("Je suis entendu");
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
}
