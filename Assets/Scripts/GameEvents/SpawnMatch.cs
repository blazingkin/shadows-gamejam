using UnityEngine;
using System.Collections;

public class SpawnMatch : GameEvent
{

	float probability;
	public SpawnMatch(float probability){
		this.probability = probability;
	}

	public string EventName(){
		return "A match appears!";
	}

	public float EventProbability(){
		return probability;
	}

	public void OnEvent(){
		GameObject.Instantiate (Resources.Load ("Prefabs/match"), PositionMath.findLocationToSpawn(0), Quaternion.identity);
	}

}