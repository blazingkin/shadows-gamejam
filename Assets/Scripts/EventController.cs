﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {
	public static ArrayList events = new ArrayList();
	float timePassed = 0;
	float timeForEvents = 1;

	// Use this for initialization
	void Start () {
		events.Add (new ExtinguishLight ());
		events.Add (new SpawnEnemy()); 
		events.Add (new SpawnMatch()); 
		events.Add (new LightningStrike ());
		events.Add (new WindGust ());
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;
		while (timePassed > timeForEvents) {
			timePassed -= timeForEvents;
			foreach (GameEvent ge in events) {
				float random = Random.Range (0.0f, 1.0f);
				if (random < ge.EventProbability ()) {
					ge.OnEvent ();
					Debug.Log ("Fired event: " + ge.EventName ());
				}
			}
		}
	}
}