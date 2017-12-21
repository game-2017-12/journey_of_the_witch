using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;
	public float walkForce = 30.0f;
	public float maxWalkSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMovement ();
	}

	void PlayerMovement(){

		int key = 0;

		if (Input.GetKey (KeyCode.RightArrow)) {
			key = 1;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			key = -1;
		}

		float speedx = Mathf.Abs (this.rigid2D.velocity.x);

		if (speedx < this.maxWalkSpeed) {
			this.rigid2D.AddForce (transform.right * key * this.walkForce);
		}

		if (key != 0) {
			transform.localScale = new Vector3 (key*0.3f, 0.3f, 0.3f);
		}
		
	}
}
