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
			PullArray[i].transform.position = new Vector3(Random.Range(x1,x2),0,Random.Range(y1,y2));
			Debug.Log(PullArray[i].name);
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
}
