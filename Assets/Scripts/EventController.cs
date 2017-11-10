using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {
	public static ArrayList events = new ArrayList();

	// Use this for initialization
	void Start () {
		events.Add (new ExtinguishLight ());	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameEvent ge in events) {
			float random = Random.Range (0.0f, 1.0f);
			if (random < ge.EventProbability ()) {
				ge.OnEvent ();
				Debug.Log("Fired event: "+ge.EventName());
			}
		}
	}
}