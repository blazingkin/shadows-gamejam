using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource{
	public static ArrayList LightSources = new ArrayList();
	public Vector2 Position;
	public double DimRadius, BrightRadius;
	public LightSource(Vector2 location, double brightRadius, double dimRadius){
		this.Position = location;
		this.DimRadius = dimRadius;	
		this.BrightRadius = brightRadius;
		LightSources.Add(this);
	}

	public void Extinguish(){
		LightSources.Remove(this);
	}

	public bool InThisLight(Vector2 location){
		Vector2 distance = new Vector2(Position.x - location.x, Position.y - location.y);
		return distance.magnitude < DimRadius;
	}

	public bool InThisBrightLight(Vector2 location){
		Vector2 distance = new Vector2(Position.x - location.x, Position.y - location.y);
		return distance.magnitude < BrightRadius;
	}

	public static bool InLight(Vector2 location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisLight(location)){
				return true;
			}
		}
		return false;
	}

	public static bool InBrightLight(Vector2 location){
		foreach (LightSource ls in LightSources) {
			if (ls.InThisBrightLight (location)) {
				return true;
			}
		}
		return false;
	}


}
