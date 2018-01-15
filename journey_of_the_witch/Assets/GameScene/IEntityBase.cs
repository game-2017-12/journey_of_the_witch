using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IEntityBase : MonoBehaviour {

	protected Rigidbody2D m_Rigid2D;
	protected float m_WalkForce = 30.0f;
	protected float m_MaxWalkSpeed = 2.0f;
	protected float m_jumpForce = 320.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	virtual public void Initialize(){
	}

	//オブジェクトを削除
	public void Finish(){
		Destroy (this.gameObject);
	}

	virtual public void PressLeftKey(){
	}
	virtual public void PressRightKey(){
	}
	virtual public void PressUpKey(){
	}
	virtual public void PressDownKey(){
	}
	virtual public void PressCKey(){
	}
	public Vector3 GetPosition(){
		return this.transform.position;
	}
}
