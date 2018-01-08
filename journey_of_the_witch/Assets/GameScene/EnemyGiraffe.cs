using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGiraffe : MonoBehaviour {

	private int m_Vector = 1;
	public float speedx = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (m_Vector * speedx + transform.position.x, transform.position.y, transform.position.z);
		transform.localScale = new Vector3 (m_Vector * 0.9f, 0.9f, 0.9f);
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "block_2_wall") {
			m_Vector *= -1;
		}
	}
}
