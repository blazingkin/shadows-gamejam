using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : GameEvent {

	float probability;
	public LightningStrike(float probability){
		this.probability = probability;
	}

	public string EventName(){
		return "Lightning Strikes!";
	}
	public float EventProbability(){
		return probability;
	}
	public void OnEvent(){
		GameObject.Instantiate (Resources.Load ("Prefabs/UI/LightningStrike"), Vector3.zero, Quaternion.identity);
	}
}
