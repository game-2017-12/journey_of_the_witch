﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySai : IEntityBase {

	public float speed = 0.01f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(speed + transform.position.x, transform.position.y, transform.position.z);
	}
}
