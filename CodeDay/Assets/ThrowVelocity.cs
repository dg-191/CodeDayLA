using UnityEngine;
using System.Collections;

public class ThrowVelocity : MonoBehaviour {

	public getForward getForward;
	Vector3 v = new Vector3();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addVelocity(){
		v = getForward.cameraForward ();
		rigidbody.velocity = v * 50;
	}
}
