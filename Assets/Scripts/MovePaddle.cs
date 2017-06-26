using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

	public float speed = 30;

	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		float v_mov = Input.GetAxisRaw ("Vertical");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v_mov) * speed;
	}
}
