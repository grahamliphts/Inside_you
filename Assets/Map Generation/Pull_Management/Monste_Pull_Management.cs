using UnityEngine;
using System.Collections;

public class Monste_Pull_Management : MonoBehaviour {

	//public Array PullArray;
	[SerializeField] public  GameObject[] PullArray;
	public float x1,y1,x2,y2;
	public int x;

	private int m_pullContentSize;
	private int m_pullSize;

	// Use this for initialization
	void Start () 
	{
		m_pullContentSize = m_pullSize = setArraySize ();
		uint i = 0;

		while (IsMonsterInPull()) {
			m_pullContentSize --;
			PullArray[i].transform.position = new Vector3(Random.Range(x1,x2),0,Random.Range(y1,y2));
			setMonster(PullArray[i]);
			//Debug.Log(PullArray[i].name);
			i ++;

			//Random.Range(10F,20F);

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	bool IsMonsterInPull()
	{
		if(m_pullContentSize > 0)
			return true;
		else
			return false;
	}
	int setArraySize()
	{
		return PullArray.Length;
	}
	void setMonster(GameObject monster)
	{
		setGrosVilain(monster);
		/*
		x = Random.Range (1, 5);
		if (x == 1) setCitronnier(monster);
		if (x == 2) setLentilles(monster);
		if (x == 3) setAgave(monster);
		if (x == 4) setTournesol(monster);
		if (x == 5) setNoisettes(monster);
		*/
		monster.SetActive (true);
	}
	
	void setGrosVilain(GameObject monster)
	{
		monster.GetComponent<Monster> ().setName ("monster");
		monster.GetComponent<Monster> ().set_name ("GrosVilain");
		monster.GetComponent<Monster> ().setOdeurRange (6.789f);
		monster.GetComponent<Monster> ().setBruitRange (0.5f);
		monster.GetComponent<Monster> ().setPv (10);
		monster.GetComponent<Monster> ().setVitamine (100);
		monster.GetComponent<Monster> ().setMagnesium (100);
		monster.GetComponent<Monster> ().setFer (500);
		monster.GetComponent<Monster> ().setGraisse (400);
		monster.GetComponent<Monster> ().setSucre (150);
		monster.GetComponent<Monster> ().setVitesseAttaque (10);
		monster.GetComponent<Monster> ().setVitesseDeplacement (10);
		monster.GetComponent<Monster> ().setPv (100);
		monster.GetComponent<Monster> ().setResistance (5);
		monster.GetComponent<Monster> ().setDegat (25);
	}
}
