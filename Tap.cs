using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
	public bool playerTap = false;		//playerをタップしたかどうかのフラグ
	public bool structureTap = false;	//structureをタップしたかどうかのフラグ
	public bool tapArea = false;		//TapAreaをタップしたかどうかのフラグ
	public GameObject[] anaumeTumiki;	//穴埋め用のプレハブ。一応、配列で管理
	GameObject player;					//検索したオブジェクト入れる用
	AudioSource audioSource;			//AudioSourceコンポーネント取得用
	public AudioClip audioClipPut;		//PutSE

	void Start () {
		player = GameObject.FindWithTag ("Player");	//Playerタグのオブジェクトを探す
		audioSource = gameObject.GetComponent<AudioSource>();	//AudioSourceコンポーネント取得
	}

	void Update () {
		//pcって仮の変数にPlayerのコンポーネントを入れる
		Player pc = player.GetComponent<Player>();

		GameObject obj = getClickObject();	//タップしたオブジェクトを入れる		
		//タップした判定
 		if(Input.GetMouseButtonDown(0)){
			Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);	//スクリーン座標

			if(obj.tag == "Player"){
//				Debug.Log("Player!!");
				playerTap = true;
			}else if(obj.tag == "Structure"){
//				Debug.Log("Structure!!");
				structureTap = true;
			}else if(obj.tag == "TapArea"){
//				Debug.Log("TapArea!!");
				//ゴール時orゲームオーバーの画面では生成しない判定
				if(pc.gameOver == false && pc.goalNow == false){
					audioSource.clip = audioClipPut;//SE決定
					audioSource.Play ();			//SE再生
					//ランダムで出現playerを決める
					int aType = Random.Range(0,4);	//0～4のランダム生成
					//穴埋め用のプレハブを生成する
					GameObject anaumeT = (GameObject)Instantiate(
						anaumeTumiki[aType],	//ランダム生成に対応する予定
						vec,
						transform.rotation
					);
				}
				tapArea = true;
			}else if(obj.tag == "Tumiki"){
				Debug.Log("Tuniki!!");
				Destroy(obj);	//オブジェクトの削除
			}
		 }

		//離した判定
		if(Input.GetMouseButtonUp(0)){
			playerTap = false;
			structureTap = false;
			tapArea = false;
 		}
	}

	//タップしたオブジェクト取得関数(とりあえす、詳しい内容は知らない)
	private GameObject getClickObject(){
		GameObject result = null;
		if(Input.GetMouseButtonDown(0)){
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);	//スクリーン座標
			Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
			if(collition2d){
				result = collition2d.transform.gameObject;
			}
		}
		return result;
	}
}
