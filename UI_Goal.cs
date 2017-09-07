using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Goal : MonoBehaviour {
	public Canvas goalCamvas;

	void Start () {
		goalCamvas.enabled = false;	//GoalUI非表示
	}
}
