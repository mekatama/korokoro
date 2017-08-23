using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureBound : MonoBehaviour {
	GameObject gameController;	//検索したオブジェクト入れる用
	private bool oneTap = false;//一回だけ処理
	AudioSource boundSound;		//AudioSourceコンポーネント取得用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
		boundSound = GetComponent<AudioSource>();	//AudioSourceコンポーネント取得
	}

	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		Tap gc = gameController.GetComponent<Tap>();
		//タッチに反応
		if(gc.structureTap && oneTap == false){
			boundSound.Play();	//SE再生
			Debug.Log("structure TAP !!");
			//ちょっとだけ拡大させる
			transform.localScale = new Vector2(1.4f, 1.4f);
			oneTap = true;
			//0.1秒後に呼び出す
			Invoke("ScaleReset", 0.1f);
		}
		//一回だけフラグの制御
		if(gc.structureTap == false){
			oneTap = false;
		}
	}

	//時間差でスケールを戻す用
	void ScaleReset(){
		//元のスケールに戻す
		transform.localScale = new Vector2(1.0f, 1.0f);
		oneTap = true;
	}
}
