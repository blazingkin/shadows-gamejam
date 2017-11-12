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

	public static void Victory(string nextLevel){
		cleanup ();
		SceneManager.LoadScene (nextLevel);
	}


	public void Tutorial(){
		SceneManager.LoadScene ("Tutorial");
	}

	public static void GameOver(){
		cleanup ();
		SceneManager.LoadScene ("GameOver");
	}

	public void LoadCave(){
		cleanup ();
		SceneManager.LoadScene ("DungeonLevel");
	}

	public void LoadCastle(){
		cleanup ();
		SceneManager.LoadScene ("CastleLevel");
	}

	private static void cleanup(){
		LightSource.resetLightSources ();
		FlammableObject.clearFlammableObjects();
		EnemyController.clearEnemies ();
		MatchUIManager.clear ();
		PlayerData.initialize ();
		EventController.events.Clear ();
	}
}
