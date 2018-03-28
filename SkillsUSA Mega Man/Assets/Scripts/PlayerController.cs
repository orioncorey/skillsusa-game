using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 25;

	private Rigidbody2D RB2D;
	private float timeInAir = 0f;

	void Start() {
		RB2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = 0f;
		if (Input.GetKeyDown("space") && timeInAir < 10) {
			timeInAir += 0.5f;
			moveVertical += 1;
		}
		if (timeInAir >= 10) {
			timeInAir -= 2;
		}
		Debug.Log (moveVertical);

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		RB2D.velocity = movement * speed;
	}
}
