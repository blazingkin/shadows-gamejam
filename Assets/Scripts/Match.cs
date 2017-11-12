using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour {

	GameObject match;
	float timePassed;
	// Use this for initialization
	void Start () {
		match = gameObject;
		timePassed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (PositionMath.playerInteractedWith (match.transform.position)) {
			Destroy (match);
			PlayerData.Matches++;
			return;
		}
		timePassed+= Time.deltaTime;
		if (timePassed > GlobalConstants.MatchLifetime) {
			Destroy (match);
			return;
		}
	}
}
