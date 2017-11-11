﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	GameObject player;
	Rigidbody2D rbody;
	Vector3 target;
	// Use this for initialization
	void Start ()
	{
		player = gameObject;
		rbody = GetComponent<Rigidbody2D> ();
		target = player.transform.position;
		PlayerData.playerObj = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			OnMouseDown ();
		}
		if ((target - player.transform.position).magnitude < GlobalConstants.PlayerStoppingDist) {
			rbody.velocity = Vector2.zero;
		}
	}

	void OnTriggerEnter2D(Collider2D collision){
		Debug.Log ("Player collided");
	}

	void OnMouseDown(){
		target = PositionMath.getMouseLocation ();
		rbody.velocity = target - player.transform.position;
		rbody.velocity /= rbody.velocity.magnitude;
		rbody.velocity *= GlobalConstants.PlayerSpeed; 
	}
}

