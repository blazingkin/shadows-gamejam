using UnityEngine;
using System.Collections;

public class SpawnEnemy : GameEvent
{

	float probability;
	public SpawnEnemy(float probability){
		this.probability = probability;
	}

	public string EventName(){
		return "An enemy approaches";
	}

	public float EventProbability(){
		return probability;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/enemy"), PositionMath.findLocationToSpawn (0), Quaternion.identity) as GameObject);
	}



}

