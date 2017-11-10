using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource{
	public static ArrayList LightSources = new ArrayList();
	public GameObject Object;
	public Light dim;
	public Light bright;
	public double DimRadius, BrightRadius;

	public LightSource(GameObject obj, double brightRadius, double dimRadius){
		this.Object = obj;
		foreach(Transform tr in obj.transform){
			if(tr.tag == "DimLight"){
				dim = tr.GetComponent<Light> ();
			}
			else if(tr.tag == "BrightLight"){
				bright = tr.GetComponent<Light> ();
			}
		}

		this.DimRadius = dimRadius;	
		this.BrightRadius = brightRadius;
		LightSources.Add(this);
		dim.enabled = true;
		bright.enabled = true;
	}

	public void Extinguish(){
		LightSources.Remove(this);
		dim.enabled = false;
		bright.enabled = false;
	}

	public bool InThisLight(Transform location){
		Vector2 distance = new Vector2(Object.transform.position.x - location.position.x, Object.transform.position.y - location.position.x);
		return distance.magnitude < DimRadius;
	}

	public bool InThisBrightLight(Transform location){
		Vector2 distance = new Vector2(Object.transform.position.x - location.position.x, Object.transform.position.y - location.position.y);
		return distance.magnitude < BrightRadius;
	}

	public static bool InLight(Transform location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisLight(location)){
				return true;
			}
		}
		return false;
	}

	public static bool InBrightLight(Transform location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisBrightLight (location)) {
				return true;
			}
		}
		return false;
	}


}
