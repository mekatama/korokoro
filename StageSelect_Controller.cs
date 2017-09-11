using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelect_Controller : MonoBehaviour {
	//Stage1用の制御関数
	public void OnStage1ButtonClicked(){
		SceneManager.LoadScene("Main");	//シーンのロード
	}
	//Stage2用の制御関数
	public void OnStage2ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main");	//シーンのロード
	}
	//Stage3用の制御関数
	public void OnStage3ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main");	//シーンのロード
	}
	//Stage4用の制御関数
	public void OnStage4ButtonClicked(){
		//シーン名は仮
		SceneManager.LoadScene("Main");	//シーンのロード
	}
}
