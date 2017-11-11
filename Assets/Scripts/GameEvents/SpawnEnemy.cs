using UnityEngine;
using System.Collections;

public class SpawnEnemy : GameEvent
{

	public string EventName(){
		return "An enemy approaches";
	}

	public float EventProbability(){
		return 1f;
	}

	public void OnEvent(){
		EnemyController.enemies.Add (GameObject.Instantiate (Resources.Load ("Prefabs/enemy"), findLocationToSpawn (), Quaternion.identity) as GameObject);
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

