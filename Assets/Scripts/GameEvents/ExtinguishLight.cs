using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguishLight : GameEvent {

	public string EventName(){
		return "A light went out!";
	}

	public float EventProbability(){
		return 0.02f;
	}
	public void OnEvent(){
		if (LightSource.LightSources.Count > 0) {
			int index = Random.Range (0, LightSource.LightSources.Count - 1);
			((LightSource) LightSource.LightSources[index]).Extinguish();
		}
	}

}
