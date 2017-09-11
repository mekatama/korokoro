using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//表示しなくする予定
public class UI_PLayer : MonoBehaviour {
	public Text playerNum;		//player数を表示するオブジェクト用
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	// Update is called once per frame
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		playerNum.text = "Player : " + gc.totalPlayer.ToString("000000");	
	}
}
