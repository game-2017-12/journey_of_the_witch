using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour {

	GameObject StartUI;
	private float nextTime;
	public float interval = 0.01f;

	// Use this for initialization
	void Start () {
		this.StartUI = GameObject.Find ("StartText");
		nextTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		StartAnime ();
	}

	void StartAnime(){
		if(Time.time > nextTime){
			//α値を取得
			float alpha = this.StartUI.GetComponent<Text>().color.a;

			if(alpha == 1.0f){
				//alphaの値を0.0fに設定する（透明）
				StartUI.GetComponent<Text>().color = new Color(50f/255f, 50f/255f, 50f/255f, 0.0f);
			}else{
				//alphaの値を1.0fに設定する（不透明）
				StartUI.GetComponent<Text>().color = new Color(50f/255f, 50f/255f, 50f/255f, 1.0f);
			}
			nextTime += interval;
		}
	}
	
}
