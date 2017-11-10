using UnityEngine;
using System.Collections;

public class SpawnEnemy : GameEvent
{

	public string EventName(){
		return "An enemy approaches";
	}

	public float EventProbability(){
		return 0.01f;
	}

	public void OnEvent(){

	}

	private Vector3 findLocationToSpawn(){
		float x, y;
		x = Random.Range (0, GlobalConstants.MapWidth);
		y = Random.Range (0, GlobalConstants.MapHeight);
		Vector3 Position = new Vector3(x, y);
		if (LightSource.InLight (Position)) {
			return Position;
		}
		return findLocationToSpawn ();
	}

}

