using UnityEngine;
using System.Collections;

public class LoseCondition : MonoBehaviour {

	public bool loseGame;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -3) {
			loseGame = true;

		}

		if (loseGame) {
			Application.LoadLevel ("MainMenu");
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == "Disc") {
			loseGame = true;
		}
	}
}
