//Originating from PUCRS Unity3D Pool
//https://github.com/fgrehm/pucrs-unity3d-pool
//For use in LMSC-281 Logic and Programming
//Audio Assignment
//Fall 2015 Jeanine Cowen

using UnityEngine;
using System;
using System.Collections;

public class ScoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var text = GetComponent<UnityEngine.UI.Text>();
		var currentPlayer = PoolGameController.GameInstance.CurrentPlayer;
		var otherPlayer = PoolGameController.GameInstance.OtherPlayer;
		text.text = String.Format("* {0} - {1}\n{2} - {3}", currentPlayer.Name, currentPlayer.Points, otherPlayer.Name, otherPlayer.Points);
	}
}
