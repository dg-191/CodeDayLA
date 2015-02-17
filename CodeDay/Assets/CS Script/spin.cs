using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {

	//public Transform center;
	public float degreesPerSecond = -65.0f;

	// Use this for initialization
	void Start () {
		//v = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, -1800 * Time.deltaTime, 0);
	}
}
