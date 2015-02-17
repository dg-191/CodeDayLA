using UnityEngine;
using System.Collections;

public class enemyMove: MonoBehaviour
{
	private int counter = 0;
	private bool goingLeft;
	private bool goingForward;
	public float movementSpeed = 10;
	private float direction = 0;
	void Start(){


	}

	void Update(){
		chooseDirection ();
		counter++;
	}

	void OnCollisionEnter (Collision col) {
			if (col.collider.tag == "Wall") {
				if(goingLeft && !goingForward)
					goRight();
				if(!goingLeft && !goingForward)
					goLeft();
				if(!goingLeft && goingForward)
					goBackward();
		}
	}

	void goRight(){
		transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		goingLeft = false;
		goingForward = false;
		}

	void goLeft(){
		transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		goingLeft = true;
		goingForward = false;
		}

	void goForward(){
		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
		goingForward = true;
		goingLeft = false;
		}

	void goBackward(){
		transform.Translate (Vector3.back * movementSpeed * Time.deltaTime);
		goingForward = false;
		goingLeft = false;
	}

	void chooseDirection(){
		direction = Random.value * 100;
		if(direction >= 0 && direction < 25)
			goRight();
		if (direction >= 25 && direction < 50)
						goLeft ();
		if (direction >= 50 && direction < 75)
						goForward ();
		if (direction >= 75 && direction < 100)
						goBackward ();
	}
}
