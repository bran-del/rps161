﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {
	private string move;
	public int GetMove() {
		// 0: (nothing)
		// 1: rock
		// 2: paper
		// 3: scissors
		return Random.Range(0,4);	// basic AI
	}

	public void ShowMoveGraphic(int move) {
		transform.GetChild(move).gameObject.SetActive(true);
	}

	public void HideMoveGraphic() {
		transform.GetChild(0).gameObject.SetActive(false);
		transform.GetChild(1).gameObject.SetActive(false);
		transform.GetChild(2).gameObject.SetActive(false);
		transform.GetChild(3).gameObject.SetActive(false);
	}
}
