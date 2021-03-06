﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour {

	public IEntityBase m_Entity;

	// Use this for initialization
	void Start () {
		if (m_Entity != null) {
			m_Entity.Initialize ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		//キー入力
		if (Input.GetKey (KeyCode.RightArrow)) {
			m_Entity.PressRightKey ();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			m_Entity.PressLeftKey ();
		}
		//変身
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			m_Entity.PressUpKey ();
		}
		//ジャンプ
		if (Input.GetKeyDown ("c")) {
			m_Entity.PressCKey ();
		}
	}


	public void SetEntity(IEntityBase e){
		//オブジェクトを削除
		if (m_Entity != null) {
			m_Entity.Finish ();
			m_Entity = null;
		}

		m_Entity = e;
		m_Entity.Initialize ();
		Debug.Log (m_Entity);
	}
}
