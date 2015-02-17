using UnityEngine;
using System.Collections;

public class enemyThrow : MonoBehaviour {

	public getForward camera;
	public ThrowVelocity disc;
	public bool canAttack = false;
	float failsafe = 0.0f;

	Vector3 aSmidgeUp = new Vector3 (0, 0.75f, 0);
	Vector3 myPosition = new Vector3(0,0,0);
	Vector3 playerPosition = new Vector3 (0, 0, 0);

	Vector3 distance = new Vector3 (0, 0, 0);

		

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		myPosition = transform.position;
		playerPosition = camera.transform.position;
		distance = playerPosition - myPosition;
		failsafe += Time.deltaTime;

		if(canAttack || failsafe >= 4){
			attack();
			canAttack = false;
		
		}
	}

	public void attack(){
		disc.transform.position = myPosition + aSmidgeUp;
		disc.rigidbody.velocity = distance * 1.5f;
		failsafe = 0.0f;
	}
}
