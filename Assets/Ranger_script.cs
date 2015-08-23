using UnityEngine;
using System.Collections;

public class Ranger_script : MonoBehaviour {

	public encounter parentInfo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void showPvParent(string perception)
	{
		if(perception=="vue")
			parentInfo.setVisibilityOn();
		if(perception=="odeur")
			parentInfo.setOdeurOn();
		if(perception=="bruit")
			parentInfo.setBruitOn();
	}
}
