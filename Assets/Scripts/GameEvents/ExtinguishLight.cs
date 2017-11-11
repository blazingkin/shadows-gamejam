using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishLight : GameEvent {

	public string EventName(){
		return "A light went out!";
	}

	public float EventProbability(){
		return .2f;
	}
	public void OnEvent(){
		if (FlammableObject.FlammableObjects.Count > 0) {
			int index = Random.Range (0, FlammableObject.FlammableObjects.Count - 1);
			if (Random.Range (0f, 1f) < FlammableObject.FlammableObjects [index].ExtinguishProbability ()) {
				FlammableObject.FlammableObjects [index].onExtinguish ();
			}
		}
	}

}
