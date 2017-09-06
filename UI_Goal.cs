using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//そもそも、このスクリプト不要かも
public class UI_Goal : MonoBehaviour {
	public Canvas goalCamvas;
	public bool goalUI = false;	//GameOver用のフラグ。player側て制御する

	// Use this for initialization
	void Start () {
		goalCamvas.enabled = false;	//GameOverUI非表示
	}
	
	// Update is called once per frame
	void Update () {
		//GoalUIの表示判定
		if(goalUI){
			goalCamvas.enabled = true;			//GameOverUI表示
		}
	}
}
