using UnityEngine;
using System.Collections;

public class SpawnEnemy : GameEvent
{

	public string EventName(){
		return "An enemy approaches";
	}

	public float EventProbability(){
		return .05f;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/enemy"), PositionMath.findLocationToSpawn (0), Quaternion.identity) as GameObject);
	}



}

