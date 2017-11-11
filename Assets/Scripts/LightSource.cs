using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource{
	public static ArrayList LightSources = new ArrayList();
	public GameObject Object;
	public Light dim;
	public Light bright;
	public GameObject dimObj;
	public GameObject brightObj;
	public float DimRadius, BrightRadius;
	public bool lit = false;

	public LightSource(GameObject obj, float brightRadius, float dimRadius){
		this.Object = obj;
		foreach(Transform tr in obj.transform){
			Debug.Log (tr.tag);
			if(tr.tag == "DimLight"){
				dimObj = tr.gameObject;
				Debug.Log ("found dim");
				dim = tr.GetComponent<Light> ();
			}
			else if(tr.tag == "BrightLight"){
				brightObj = tr.gameObject;
				Debug.Log ("found bright");
				bright = tr.GetComponent<Light> ();
			}
		}

		this.DimRadius = dimRadius;	
		this.BrightRadius = brightRadius;
		LightSources.Add(this);
		UpdateLighting ();
		//dimObj.SetActive (true);
		//brightObj.SetActive (true);
		dim.enabled = true;
		bright.enabled = true;
		lit = true;
	}

	public void UpdateLighting(){
		dim.spotAngle = RadiusToSpot (DimRadius);
		bright.spotAngle = RadiusToSpot (BrightRadius);
	}

	public void Extinguish(){
		LightSources.Remove(this);
		dim.enabled = false;
		bright.enabled = false;
		lit = false;
	}

	public bool InThisLight(Vector3 location){
		Vector2 distance = new Vector2(Object.transform.position.x - location.x, Object.transform.position.y - location.x);
		return distance.magnitude < DimRadius;
	}

	public bool InThisBrightLight(Vector3 location){
		Vector2 distance = new Vector2(Object.transform.position.x - location.x, Object.transform.position.y - location.y);
		return distance.magnitude < BrightRadius;
	}

	public static bool InLight(Vector3 location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisLight(location)){
				return true;
			}
		}
		return false;
	}

	public static bool InBrightLight(Vector3 location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisBrightLight (location)) {
				return true;
			}
		}
		return false;
	}

	private float RadiusToSpot(float radius){
		//Debug.Log (Mathf.Atan (radius));
		//Debug.Log (Mathf.Rad2Deg * Mathf.Atan (radius));
		return Mathf.Rad2Deg * Mathf.Atan (radius) * 2;
	}

}
