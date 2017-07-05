using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle2 : MonoBehaviour {

	public static int speed = 30;
	Rigidbody2D rb;
	GameObject bp;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		bp = GameObject.Find ("ball");
	}
	
	// Update is called once per frame
	void Update () {
		if (gameMode.gamem == 0) {
			AI ();
		} 
		else if (gameMode.gamem == 1) {
			playerControl ();
		}
	}

	void playerControl () {
		if (Input.GetKey (KeyCode.I)) {
			rb.velocity = Vector2.up * speed;
		} else if (Input.GetKey (KeyCode.K)) {
			rb.velocity = Vector2.down * speed;
		} else {
			rb.velocity = new Vector2(0, 0);
		}
	}

	void AI () {
		if (bp.GetComponent<Rigidbody2D>().position.y > rb.position.y) {
			rb.velocity = Vector2.up * speed;
		} 
		else if (bp.GetComponent<Rigidbody2D>().position.y < rb.position.y) {
			rb.velocity = Vector2.down * speed;
		} 
		else {
			rb.velocity = new Vector2(0, 0);
		}
	}
}
