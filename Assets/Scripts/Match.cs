using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour {

	GameObject match;
	// Use this for initialization
	void Start () {
		match = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (PositionMath.playerInteractedWith (match.transform.position)) {
			Destroy (match);
			PlayerData.Matches++;
		}
	}
}
