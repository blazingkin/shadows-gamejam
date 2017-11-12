using UnityEngine;
using System.Collections;

public class Rain : GameEvent
{

	public string EventName(){
		return "It's Raining";
	}
	public float EventProbability(){
		return .02f;
	}
	public void OnEvent(){
		GameObject.Instantiate (Resources.Load ("Prefabs/ParticleEffects/Rain"), GlobalConstants.RainPos, GlobalConstants.RainRotation);
	}
}

