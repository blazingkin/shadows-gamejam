﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

	Light light;
	public float intensity;
	public float randomIntensity;
	public float minIntensity = 3f, maxIntesity = 5f;
	public float timeDelay = .05f;
	float time =  0;
	public bool updateIntesity = false;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}

	// Update is called once per frame
	void Update () {

		if(updateIntesity){
			
		}

		/*time += Time.deltaTime;
		while (time > timeDelay) {
			time -= timeDelay;
			intensity = Random.Range (minIntensity, maxIntesity);
			light.intensity = intensity;
		}*/
	}
}
