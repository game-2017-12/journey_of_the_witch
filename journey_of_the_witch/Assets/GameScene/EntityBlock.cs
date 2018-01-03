using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBlock : IEntityBase {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	override public void Initialize(){
		this.m_Rigid2D = GetComponent<Rigidbody2D> ();
	}
	override public void PressLeftKey(){
	}
	override public void PressRightKey(){
	}
	override public void PressUpKey(){
		var e = GameObject.Find ("entityGenerator").GetComponent<EntityGenerator> ().GenerateEntity (0, this.GetPosition());
		GameObject.Find ("entityController").GetComponent<EntityController> ().SetEntity (e);
	}
	override public void PressDownKey(){
	}
}
