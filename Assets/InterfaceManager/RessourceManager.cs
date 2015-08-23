using UnityEngine;
using System.Collections;
using  UnityEngine.UI;

public class RessourceManager : MonoBehaviour {

	[SerializeField] private Text Value;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateValue(int newValue)
	{
		Value.text = newValue.ToString();
	}
}
