using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntityPlayer : IEntityBase {

	private int m_Vector = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
		m_Vector = 0;
	}

	override public void Initialize(){
		this.m_Rigid2D = GetComponent<Rigidbody2D> ();
	}
	override public void PressLeftKey(){
		m_Vector = -1;
	}
	override public void PressRightKey(){
		m_Vector = 1;
	}
	override public void PressUpKey(){
		//箱に変身
		var e = GameObject.Find ("entityGenerator").GetComponent<EntityGenerator> ().GenerateEntity (1, this.GetPosition ());
		GameObject.Find ("entityController").GetComponent<EntityController> ().SetEntity (e);

	}
	override public void PressDownKey(){
	}

	private void Movement(){
		float speedx = Mathf.Abs (this.m_Rigid2D.velocity.x);

		if(speedx < this.m_MaxWalkSpeed){
			this.m_Rigid2D.AddForce(transform.right * m_Vector * this.m_WalkForce);
		}
		//向きによって画像を反転
		if(m_Vector != 0){
			transform.localScale = new Vector3 (m_Vector * 0.3f, 0.3f, 0.3f);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "goal") {
			SceneManager.LoadScene ("ResultScene");
		}
	}
}
