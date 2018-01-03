using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectController : MonoBehaviour {

	private int stagenum = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Select ();
	}

	void Select(){

		switch (stagenum) {
		case 1:
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.position = new Vector3 (-1.5f, transform.position.y, 0f);
				stagenum = 2;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.position = new Vector3 (2.6f, transform.position.y, 0f);
				stagenum = 3;
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				SceneManager.LoadScene ("GameScene");
			}
			break;
		case 2:
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.position = new Vector3 (2.6f, transform.position.y, 0f);
				stagenum = 3;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.position = new Vector3 (-5.9f, transform.position.y, 0f);
				stagenum = 1;
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				SceneManager.LoadScene ("GameScene");
			}
			break;
		case 3:
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.position = new Vector3 (-5.9f, transform.position.y, 0f);
				stagenum = 1;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.position = new Vector3 (-1.5f, transform.position.y, 0f);
				stagenum = 2;
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				SceneManager.LoadScene ("GameScene");
			}
			break;
		}
	}
}
