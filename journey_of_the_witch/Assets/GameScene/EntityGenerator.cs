using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//変身

public class EntityGenerator : MonoBehaviour {

	public GameObject player;
	public GameObject block;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEntityBase GenerateEntity(int id, Vector3 pos){
		//プレイヤーのインスタンスを作成
		if (id == 0) {
			GameObject e = Instantiate (player) as GameObject;
			e.name = "entityPlayerPrefab";
			e.transform.position = pos;
			return e.GetComponent<IEntityBase> ();
		}
		//箱のインスタンスを作成
		if (id == 1) {
			GameObject e = Instantiate (block) as GameObject;
			e.transform.position = pos;
			return e.GetComponent<IEntityBase> ();
		}

		return null;
	}
}
