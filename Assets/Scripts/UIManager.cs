using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame(){
		SceneManager.LoadScene ("GrassLevel");
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public static void GameOver(){
		cleanup ();
		SceneManager.LoadScene ("GameOver");
	}


	private static void cleanup(){
		LightSource.resetLightSources ();
		FlammableObject.clearFlammableObjects();
		EnemyController.clearEnemies ();
		PlayerData.initialize ();
		MatchUIManager.clear ();
	}
}
