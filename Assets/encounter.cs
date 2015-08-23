using UnityEngine;
using System.Collections;

public class encounter : MonoBehaviour {
	public int Pv = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getPV()
	{
		return Pv;
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
}
