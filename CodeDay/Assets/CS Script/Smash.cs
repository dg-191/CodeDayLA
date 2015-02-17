using UnityEngine;
using System.Collections;

public class Smash : MonoBehaviour {
	public IdleDisc home;
	Color initial = new Color32(255, 255, 255, 255);
	Color additive = new Color32(25, 25, 25, 0);
	int counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == "Disc") {
			home.setIdleTrue ();
			//Destroy(this.gameObject);
			initial -= additive;
			counter++;
			transform.renderer.material.color = initial;

			if(counter >= 10)
				Destroy(this.gameObject);
		}
	}
}