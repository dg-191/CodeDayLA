using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	Vector3 aSmidge = new Vector3(0, 1, 1);
	public ThrowVelocity ThrowVelocity;
	public IdleDisc home;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && home.idleDisc) {
			home.setIdleFalse();
			ThrowVelocity.gameObject.transform.position = transform.position + aSmidge;
			ThrowVelocity.addVelocity ();
		}
	}
}
