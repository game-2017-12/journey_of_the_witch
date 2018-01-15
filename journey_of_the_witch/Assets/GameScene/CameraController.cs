using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	GameObject player;
	private bool startFlag = false;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("entityPlayerPrefab");

		if (player != null) {
			Vector3 playerPos = this.player.transform.position;

			if (playerPos.x >= this.transform.position.x) {
				startFlag = true;
			} else if(startPos.x >= this.transform.position.x){
				startFlag = false;
			}
			if (startFlag == true) {
				transform.position = new Vector3 (playerPos.x, transform.position.y, transform.position.z);

			}
		}
	}
}
