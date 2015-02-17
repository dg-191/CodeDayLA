using UnityEngine;
using System.Collections;

public class IdleDisc : MonoBehaviour {

	public bool idleDisc;
	public getForward getForward;
	Vector3 handPosition = new Vector3(0, -1, 1);
	Quaternion discStart = new Quaternion(335, 0, 0, 0);
	Vector3 velocityStart = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
		setIdleTrue();
	}
	
	// Update is called once per frame
	void Update () {
		if(idleDisc || transform.position.y < 0) {
			transform.rotation = discStart;
			transform.position = getForward.gameObject.transform.position + handPosition;
			rigidbody.velocity = velocityStart;
		}
	}

	public void setIdleTrue(){
		idleDisc = true;
	}

	public void setIdleFalse(){
		idleDisc = false;
	}
}
