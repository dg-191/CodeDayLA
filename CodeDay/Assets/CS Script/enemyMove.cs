//make sure to add comments to any code changed
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

	void OnCollisionEnter (Collision col) { //This will detect a hit against the wall and return disk to enemy
			if (col.collider.tag == "Wall") {
				if(goingLeft && !goingForward)
					goRight();
				if(!goingLeft && !goingForward)
					goLeft();
				if(!goingLeft && goingForward)
					goBackward();
		}
	}

	void goRight(){//moves enemy right
		transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		goingLeft = false;
		goingForward = false;
	}

	void goLeft(){//moves enemy left
		transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
		goingLeft = true;
		goingForward = false;
	}

	void goForward(){//moves enemy forward
		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
		goingForward = true;
		goingLeft = false;
	}

	void goBackward(){//moves enemy backwards
		transform.Translate (Vector3.back * movementSpeed * Time.deltaTime);
		goingForward = false;
		goingLeft = false;
	}

	void chooseDirection(){//randomly allows the enemy to choose its direction of motion
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
