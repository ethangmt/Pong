using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class buttonMenuClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && Input.mousePosition.x > 126 && Input.mousePosition.x < 285
			&& Input.mousePosition.y > 78 && Input.mousePosition.y < 109) {
			gameMode.gamem = 0;
			EditorSceneManager.LoadScene ("main_scene");
		}
		else if (Input.GetMouseButton (0) && Input.mousePosition.x > 333 && Input.mousePosition.x < 495
		    && Input.mousePosition.y > 78 && Input.mousePosition.y < 109) {
			gameMode.gamem = 1;
			EditorSceneManager.LoadScene ("main_scene");
		}
	}
}
