using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordClock : MonoBehaviour {

	GameObject moon;
	float gameLength = GlobalConstants.GameLength * 60;
	Rigidbody2D rbody;
	Vector2 speed;
	public string nextLevel;

	// Use this for initialization
	void Start () {
		moon = GameObject.Instantiate (Resources.Load ("Prefabs/UI/Moon"), new Vector2(-15.5f, 8.1f), Quaternion.identity) as GameObject;
		rbody = moon.GetComponent<Rigidbody2D> ();
		speed = new Vector2 ((GlobalConstants.MapWidth + GlobalConstants.EndMoonPos)/(gameLength), 0);
		rbody.velocity = speed;
	}

	// Update is called once per frame
	void Update () {
		if(moon.transform.position.x >= GlobalConstants.EndMoonPos){
			UIManager.Victory (nextLevel);
		}
	}



}
