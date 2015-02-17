using UnityEngine;
using System.Collections;

public class getForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.lockCursor = true;
		Screen.lockCursor = false;
	}

	public Vector3 cameraForward() {
		Vector3 v = new Vector3();
		v = transform.forward;
		return v;
	}
}
