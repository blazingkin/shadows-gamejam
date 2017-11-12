using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStrike : GameEvent {

	public string EventName(){
		return "Lightning Strikes!";
	}
	public float EventProbability(){
		return .02f;
	}
	public void OnEvent(){
		GameObject.Instantiate (Resources.Load ("Prefabs/UI/LightningStrike"), Vector3.zero, Quaternion.identity);
	}
}
