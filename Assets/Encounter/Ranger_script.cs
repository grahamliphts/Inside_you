using UnityEngine;
using System.Collections;

public class Ranger_script : MonoBehaviour {
	[SerializeField] private SphereCollider m_collider;
	public encounter parentInfo;
	// Use this for initialization
	void Start () {
		if(this.name == "odeur")
			m_collider.radius = parentInfo.getOdeurRadius ();
		if(this.name == "bruit")
			m_collider.radius = parentInfo.getBruitRadius ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void showParent(string perception)
	{
		if(perception=="vue")
			parentInfo.setVisibilityOn();
		if(perception=="bruit")
			parentInfo.setBruitOn();
		if(perception=="odeur")
			parentInfo.setOdeurOn();
	}
}
