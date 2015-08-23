using UnityEngine;
using System.Collections;

public class Bouffe_pull : MonoBehaviour {
	//public Array PullArray;
	[SerializeField] public  GameObject[] PullArray;
	public float x1,y1,x2,y2;
	
	private int m_pullContentSize;
	private int m_pullSize;
	
	// Use this for initialization
	void Start () 
	{
		m_pullContentSize = m_pullSize = setArraySize ();
		uint i = 0;
		
		while (IsBouffeInPull()) {
			m_pullContentSize --;
			PullArray[i].transform.position = new Vector3(Random.Range(x1,x2)-2,0f,Random.Range(y1,y2));
			setBouffe(PullArray[i]);
			//Debug.Log(PullArray[i].name);
			i ++;
			
			//Random.Range(10F,20F);
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	bool IsBouffeInPull()
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

	void setBouffe(GameObject encounter)
	{
		setCitronnier(encounter);
		encounter.SetActive (true);
	}

	void setCitronnier(GameObject encounter)
	{
		encounter.GetComponent<encounter> ().setName ("Citronnier");
		encounter.GetComponent<encounter> ().setOdeurRange (6.789f);
		encounter.GetComponent<encounter> ().setBruitRange (0.5f);
		encounter.GetComponent<encounter> ().setPv (10);
	}
	void setLentilles(GameObject encounter) //riche en fer
		//Graines de soja, Lentilles, Haricots blancs, Pois chiches, Tofu, abricot
	{
		encounter.GetComponent<encounter> ().setName ("Lentilles");
		encounter.GetComponent<encounter> ().setOdeurRange (3.5f);
		encounter.GetComponent<encounter> ().setBruitRange (0.5f);
		encounter.GetComponent<encounter> ().setPv (10);
	}
	
	void setTournesol(GameObject encounter) //riche en magnésium
		//Tournesol, blé
	{
		encounter.GetComponent<encounter> ().setName ("Tournesol");
		encounter.GetComponent<encounter> ().setOdeurRange (10f);
		encounter.GetComponent<encounter> ().setBruitRange (0.5f);
		encounter.GetComponent<encounter> ().setPv (10);
	}
	
	void setAgave(GameObject encounter) //Riche en sucre
		//Fraise, framboise
	{
		encounter.GetComponent<encounter> ().setName ("Agave");
		encounter.GetComponent<encounter> ().setOdeurRange (3.5f);
		encounter.GetComponent<encounter> ().setBruitRange (0.5f);
		encounter.GetComponent<encounter> ().setPv (10);
	}
	
	void setNoisettes(GameObject encounter) //Riche en graisse
		//Noisettes, noix, olives
	{
		encounter.GetComponent<encounter> ().setName ("Noisettes");
		encounter.GetComponent<encounter> ().setOdeurRange (3.5f);
		encounter.GetComponent<encounter> ().setBruitRange (0.5f);
		encounter.GetComponent<encounter> ().setPv (10);
	}
}
