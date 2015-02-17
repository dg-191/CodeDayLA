using UnityEngine;
using System.Collections;

public class DiscReturn : MonoBehaviour {

	public IdleDisc home;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == "Panel") {
			home.setIdleTrue();
		}
	}
}