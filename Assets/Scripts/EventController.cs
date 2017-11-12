using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour {
	public static ArrayList events = new ArrayList();
	float timePassed = 0;
	float timeForEvents = 1;

	public float extinguishLightProbability, spawnEnemyProbability, spawnMatchProbability, lightningStrikeProbability, windGustProbability, rainProbability;
	public string enemyName;

	// Use this for initialization
	void Start () {
		events.Add (new ExtinguishLight (extinguishLightProbability));
		events.Add (new SpawnEnemy(spawnEnemyProbability, enemyName)); 
		events.Add (new SpawnMatch(spawnMatchProbability)); 
		events.Add (new LightningStrike (lightningStrikeProbability));
		events.Add (new WindGust (windGustProbability));
		events.Add (new Rain (rainProbability));
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