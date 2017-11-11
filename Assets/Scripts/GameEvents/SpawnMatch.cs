using UnityEngine;
using System.Collections;

public class SpawnMatch : GameEvent
{

	public string EventName(){
		return "A match appears!";
	}

	public float EventProbability(){
		return .01f;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/match"), findLocationToSpawn (), Quaternion.identity) as GameObject);
	}

	private Vector3 findLocationToSpawn(){
		float x, y;
		x = Random.Range (-GlobalConstants.MapWidth, GlobalConstants.MapWidth);
		y = Random.Range (-GlobalConstants.MapHeight, GlobalConstants.MapHeight);
		Vector3 Position = new Vector3(x, y);
		if (!LightSource.InLight (Position)) {
			return Position;
		}
		return findLocationToSpawn ();
	}

}