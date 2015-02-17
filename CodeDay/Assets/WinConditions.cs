using UnityEngine;
using System.Collections;

public class WinConditions : MonoBehaviour {

	public bool winGame = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -3)
			winGame = true;

		if (winGame) {
			Application.LoadLevel ("WinScreen");
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == "Disc") {
			winGame = true;
		}
	}
}