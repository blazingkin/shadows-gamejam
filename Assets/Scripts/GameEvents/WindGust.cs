using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGust : GameEvent {

	public string EventName(){
		return "A gust of wind blows";
	}

	public float EventProbability(){
		return .015f;
	}

	public void OnEvent(){
		while (FlammableObject.LitFlammableObjects.Count > 0) {
			FlammableObject.LitFlammableObjects [0].onExtinguish ();
		}
		GameObject.Instantiate (Resources.Load ("Prefabs/ParticleEffects/GustOWind"), GlobalConstants.GustOWindPos , Quaternion.Euler(new Vector3(0, 90, -90)));
	}
}
