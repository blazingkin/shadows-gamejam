using UnityEngine;
using System.Collections;

public class Rain : GameEvent
{

	float probability;
	public Rain(float probability){
		this.probability = probability;
	}

	public string EventName(){
		return "It's Raining";
	}
	public float EventProbability(){
		return probability;
	}
	public void OnEvent(){
		GameObject.Instantiate (Resources.Load ("Prefabs/ParticleEffects/Rain"), GlobalConstants.RainPos, GlobalConstants.RainRotation);
	}
}

