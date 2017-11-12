using UnityEngine;
using System.Collections;

public class SpawnEnemy : GameEvent
{

	float probability;
	string enemyName;
	public SpawnEnemy(float probability, string enemyName){
		this.probability = probability;
		this.enemyName = enemyName;
	}

	public string EventName(){
		return "An enemy ("+enemyName+") approaches";
	}

	public float EventProbability(){
		return probability;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/Monsters/"+enemyName), PositionMath.findLocationToSpawn (0), Quaternion.identity) as GameObject);
	}



}

