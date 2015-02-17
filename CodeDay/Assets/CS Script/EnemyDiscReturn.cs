using UnityEngine;
using System.Collections;

public class EnemyDiscReturn : MonoBehaviour {

	public enemyThrow enemyThrow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == "Panel") {
			enemyThrow.canAttack = true;
		}
	}
}