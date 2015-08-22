using UnityEngine;
using System.Collections;

public class Ranger_script : MonoBehaviour {

	public get_info parentInfo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void showPvParent()
	{
		Debug.Log (parentInfo.getPV());
	}
}
