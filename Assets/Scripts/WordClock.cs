using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordClock : MonoBehaviour {

	GameObject moon;
	float gameLength = GlobalConstants.GameLength * 60;
	Rigidbody2D rbody;
	Vector2 speed;

	// Use this for initialization
	void Start () {
		moon = GameObject.Instantiate (Resources.Load ("Prefabs/Moon"), new Vector2(-15.5f, 8.5f), Quaternion.identity) as GameObject;
		rbody = moon.GetComponent<Rigidbody2D> ();
		speed = new Vector2 ((2*GlobalConstants.MapWidth)/(gameLength), 0);
		Debug.Log (speed);
		rbody.velocity = speed;
	}

	// Update is called once per frame
	void Update () {
	}
}
