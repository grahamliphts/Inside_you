using UnityEngine;
using System.Collections;

public class encounter : MonoBehaviour {
	[SerializeField] private int m_Pv = 10;
	[SerializeField] private float m_odeurRadius=0.5f;
	[SerializeField] private float m_bruitRadius=0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getPV()
	{
		return m_Pv;
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
