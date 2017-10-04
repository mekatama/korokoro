using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage_Controller : MonoBehaviour {

	//タイトルに戻るボタン用の制御関数(StageSelect用)
	public void OnReturnTitleButtonSelectClicked(){
		SceneManager.LoadScene("Title");	//シーンのロード
	}

}
