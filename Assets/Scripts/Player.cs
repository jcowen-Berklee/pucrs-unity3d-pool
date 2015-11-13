//Originating from PUCRS Unity3D Pool
//https://github.com/fgrehm/pucrs-unity3d-pool
//For use in LMSC-281 Logic and Programming
//Audio Assignment
//Fall 2015 Jeanine Cowen

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Player {
	private IList<Int32> ballsCollected = new List<Int32>();

	public Player(string name) {
		Name = name;
	}

	public string Name {
		get;
		private set;
	}

	public int Points {
		get { return ballsCollected.Count; }
	}

	public void Collect(int ballNumber) {
		Debug.Log(Name + " collected ball " + ballNumber);
		ballsCollected.Add(ballNumber);
	}
}
