using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float speed = 30;

	private Rigidbody2D rigidBody;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = Vector2.right * speed;
	}

	void OnCollisionEnter2D (Collision2D collision) {
		// wall top or bottom
		if (collision.gameObject.name == "wall_top" || collision.gameObject.name == "wall_bottom") {
			SoundManager.Instance.PlayOneShot (SoundManager.Instance.hit);
		}

		if (collision.gameObject.name == "leftPaddle" || collision.gameObject.name == "rightPaddle") {
			handlePaddleHit (collision);
		}

		if (collision.gameObject.name == "wall_left" || collision.gameObject.name == "wall_right") {
			SoundManager.Instance.PlayOneShot (SoundManager.Instance.hit);

			//TODO update score

			transform.position = new Vector2 (0, 0);
		}
	}

	void handlePaddleHit (Collision2D coll) {
		float y = ballHitPaddle (transform.position, coll.transform.position, coll.collider.bounds.size.y);

		Vector2 dir = new Vector2 ();

		if (coll.gameObject.name == "leftPaddle") {
			dir = new Vector2 (1, y).normalized; 
		}

		if (coll.gameObject.name == "rightPaddle") {
			dir = new Vector2 (-1, y).normalized; 
		}

		rigidBody.velocity = dir * speed;

		SoundManager.Instance.PlayOneShot (SoundManager.Instance.hit);
	}

	float ballHitPaddle (Vector2 ball, Vector2 paddle, float paddleHeight) {
		return (ball.y - paddle.y) / paddleHeight;
	}
}
