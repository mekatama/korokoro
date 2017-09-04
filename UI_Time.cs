using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Time : MonoBehaviour {
	public Text time;			//player数を表示するオブジェクト用
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		time.text = "Time : " + gc.timePlaying.ToString("000.000");
	}
}
