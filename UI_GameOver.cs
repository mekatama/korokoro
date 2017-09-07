using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameOver : MonoBehaviour {
	public Canvas gameOverCamvas;

	void Start () {
		gameOverCamvas.enabled = false;	//GameOverUI非表示
	}
}
