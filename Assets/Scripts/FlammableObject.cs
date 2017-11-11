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

	public void Start(){
		foreach(Transform tr in transform){
			if(tr.tag == "LightObj"){
				lightObject = tr.gameObject;
			}
		}
		this.Position = transform.position;
	}

	public void onLit(){
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
			Vector3 mousePos = PositionMath.getMouseLocation();
			if ((transform.position - mousePos).magnitude < GlobalConstants.InteractionDistance){
				Debug.Log (lightSource);
				if (lightSource == null || lightSource.lit == false) {
					if ((PositionMath.getPlayerPosition () - transform.position).magnitude < GlobalConstants.PlayerInteractionDistance) {
						onLit ();
					}
				}
			}
		}
	}

}

