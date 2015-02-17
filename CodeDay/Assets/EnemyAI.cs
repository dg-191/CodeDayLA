using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	int moveChangeRate = 2;
	float counter = 0.0f;

	Vector3 tile1 = new Vector3(10, 1, 60);
	Vector3 tile2 = new Vector3(10, 1, 50);
	Vector3 tile3 = new Vector3(10, 1, 40);
	Vector3 tile4 = new Vector3(20, 1, 60);
	Vector3 tile5 = new Vector3(20, 1, 50);
	Vector3 tile6 = new Vector3(20, 1, 40);
	Vector3 tile7 = new Vector3(30, 1, 60);
	Vector3 tile8 = new Vector3(30, 1, 50);
	Vector3 tile9 = new Vector3(30, 1, 40);

	Vector3 me = new Vector3(0, 0, 0);
	void Start() {
		changeMove ();
	}

	void Update () {
		me = transform.position;
		counter += Time.deltaTime;
		if (counter >= moveChangeRate) {
			changeMove();
			counter = 0;
		}

	}

	void changeMove() {
		int chooser = Random.Range (1, 10);
		Vector3 decision = new Vector3 (0, 0, 0);
		switch (chooser) {
				case 1:
						decision = (tile1 - me);
						rigidbody.velocity = decision;
						break;
				case 2:
						decision = (tile2 - me);
						rigidbody.velocity = decision;
						break;
				case 3:
						decision = (tile3 - me);
						rigidbody.velocity = decision;
						break;
				case 4:
						decision = (tile4 - me);
						rigidbody.velocity = decision;
						break;
				case 5:
						decision = (tile5 - me);
						rigidbody.velocity = decision;
						break;
				case 6:
						decision = (tile6 - me);
						rigidbody.velocity = decision;
						break;
				case 7:
						decision = (tile7 - me);
						rigidbody.velocity = decision;
						break;
				case 8:
						decision = (tile8 - me);
						rigidbody.velocity = decision;
						break;
				case 9:
						decision = (tile9 - me);
						rigidbody.velocity = decision;
						break;
				}
		}
}