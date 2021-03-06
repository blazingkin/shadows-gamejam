﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* More like inflammable object, amirite */
public class FlammableObject : MonoBehaviour
{
	public static List<FlammableObject> FlammableObjects = new List<FlammableObject> ();
	public static List<FlammableObject> LitFlammableObjects = new List<FlammableObject>();

	public Vector3 Position;
	public float DimRadius, BrightRadius = 0f;
	protected LightSource lightSource = null;
	public GameObject lightObject;
	public bool shouldStartLit = false;
	public Sprite litSprite;
	public Sprite extinguishedSprite;
	public float timePassed = 0f;

	public void Start(){
		foreach(Transform tr in transform){
			if(tr.tag == "LightObj"){
				lightObject = tr.gameObject;
			}
		}
		this.Position = transform.position;
		FlammableObjects.Add(this);
		if (shouldStartLit) {
			onLit ();
		}
	}

	public virtual void onLit(){
		lightSource = new LightSource(lightObject, BrightRadius, DimRadius);
		GetComponent<SpriteRenderer> ().sprite = litSprite;
		timePassed = 0;
		LitFlammableObjects.Add (this);
	}

	public virtual void onExtinguish(){
		if (null != lightSource) {
			lightSource.Extinguish();
		}
		lightSource = null;
		GetComponent<SpriteRenderer> ().sprite = extinguishedSprite;
		LitFlammableObjects.Remove (this);
	}

	public virtual void Update(){
		timePassed += Time.deltaTime;
		if (PositionMath.playerInteractedWith (transform.position)) {
			if (lightSource == null || lightSource.lit == false) {
				if (PlayerData.useMatch ()) {
					onLit ();
				}
			}
		}
	}

	public virtual float ExtinguishProbability(){
		if (timePassed < GlobalConstants.TorchTimeToRandomExtinguish) {
			return 0f;
		}
		return 1f;
	}

	public static void clearFlammableObjects(){
		FlammableObjects = new List<FlammableObject>();
	}

}

