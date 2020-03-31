﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	
	bool gameHasEnded = false;
	public float restartDelay = 2f;

	public void EndGame () {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game Over");
			//Restart Game
			Invoke("Restart", restartDelay);
		}
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
