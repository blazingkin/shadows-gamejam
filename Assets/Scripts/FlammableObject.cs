using System;
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

	public void onLit(){
		Debug.Log ("It's lit fam");
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

