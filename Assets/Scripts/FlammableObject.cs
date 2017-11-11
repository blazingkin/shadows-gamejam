using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* More like inflammable object, amirite */
public class FlammableObject : MonoBehaviour
{
	public static List<FlammableObject> FlammableObjects = new List<FlammableObject> ();

	public Vector3 Position;
	public float DimRadius, BrightRadius = 0f;
	protected LightSource lightSource = null;
	public GameObject lightObject;
	public bool shouldStartLit = false;
	public Sprite litSprite;
	public Sprite extinguishedSprite;

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
	}

	public virtual void onExtinguish(){
		if (null != lightSource) {
			lightSource.Extinguish();
		}
		lightSource = null;
		GetComponent<SpriteRenderer> ().sprite = extinguishedSprite;
	}

	public virtual void Update(){
		if (Input.GetMouseButtonDown (1)) {
			Vector3 mousePos = PositionMath.getMouseLocation();
			if ((transform.position - mousePos).magnitude < GlobalConstants.InteractionDistance){
				if (lightSource == null || lightSource.lit == false) {
					if ((PositionMath.getPlayerPosition () - transform.position).magnitude < GlobalConstants.PlayerInteractionDistance) {
						if (PlayerData.useMatch ()) {
							onLit ();
						}
					}
				}
			}
		}
	}

	public virtual float ExtinguishProbability(){
		return 1f;
	}

	public static void clearFlammableObjects(){
		FlammableObjects = new List<FlammableObject>();
	}

}

