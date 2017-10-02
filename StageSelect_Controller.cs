using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelect_Controller : MonoBehaviour {
	AudioSource audioSource;			//AudioSourceコンポーネント取得用
	public AudioClip audioClipStart;	//StartSE

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();	//AudioSourceコンポーネント取得
		audioSource.clip = audioClipStart;	//SE決定
		audioSource.Play ();				//SE再生
	}

	//Stage1用の制御関数
	public void OnStage1ButtonClicked(){
		SceneManager.LoadScene("Main1");	//シーンのロード
	}
	//Stage2用の制御関数
	public void OnStage2ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main2");	//シーンのロード
	}
	//Stage3用の制御関数
	public void OnStage3ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main4");	//シーンのロード
	}
	//Stage4用の制御関数
	public void OnStage4ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main3");	//シーンのロード
	}

	//タイトルに戻るボタン用の制御関数(StageSelect用)
	public void OnReturnTitleButtonSelectClicked(){
		SceneManager.LoadScene("Title");	//シーンのロード
	}
}
