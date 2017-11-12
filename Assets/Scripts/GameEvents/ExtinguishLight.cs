using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishLight : GameEvent {

	public string EventName(){
		return "A light went out!";
	}

	public float EventProbability(){
		return .15f;
	}
	public void OnEvent(){
		if (FlammableObject.LitFlammableObjects.Count > 0) {
			int index = Random.Range (0, FlammableObject.LitFlammableObjects.Count - 1);
			if (Random.Range (0f, 1f) < FlammableObject.LitFlammableObjects [index].ExtinguishProbability ()) {
				FlammableObject.LitFlammableObjects [index].onExtinguish ();
			}
		}
	}

}
