﻿using System;
using System.Collections;
using UnityEngine;

/* More like inflammable object, amirite */
public class FlammableObject : MonoBehaviour
{
	public Vector3 Position;
	public float DimRadius, BrightRadius = 0f;
	private LightSource lightSource = null;
	public GameObject lightObject;

	public FlammableObject (Vector3 position){
		this.Position = position;
	}

	public void Start(){
		foreach(Transform tr in transform){
			if(tr.tag == "LightObj"){
				lightObject = tr.gameObject;
			}
		}
		this.Position = transform.position;
		onLit ();
	}

	public void onLit(){
		if (null != lightSource) {
			lightSource.Extinguish();
		}
		lightSource = new LightSource(lightObject, BrightRadius, DimRadius);
	}

	public void onExtinguish(){
		if (null != lightSource) {
			lightSource.Extinguish();
		}
		lightSource = null;
	}

	void Update(){
		if (Input.GetMouseButtonDown (1)) {
			Debug.Log ("RMB");
			Vector3 mousePos = PositionMath.getMouseLocation();
			if ((Position - mousePos).magnitude < GlobalConstants.PlayerInteractionDist){
				if (lightSource == null) {
					onLit ();
				}
			}
		}
	}

}

