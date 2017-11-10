using System;
using System.Collections;
using UnityEngine;

/* More like inflammable object, amirite */
public class FlammableObject : MonoBehaviour
{
	public Vector2 Position;
	public float DimRadius, BrightRadius = 0f;
	private LightSource lightSource = null;
	public GameObject lightObject;

	public FlammableObject (Vector2 position){
		this.Position = position;
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
}

