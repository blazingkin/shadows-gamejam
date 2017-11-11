using UnityEngine;
using System.Collections;

public class SpawnMatch : GameEvent
{

	public string EventName(){
		return "A match appears!";
	}

	public float EventProbability(){
		return .075f;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/match"), PositionMath.findLocationToSpawn(0), Quaternion.identity) as GameObject);
	}

}