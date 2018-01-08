using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("entityPlayerPrefab");

		if (player != null) {
			Vector3 playerPos = this.player.transform.position;
			transform.position = new Vector3 (playerPos.x, transform.position.y, transform.position.z);
		}
	}
}
