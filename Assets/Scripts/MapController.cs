using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

	GameObject map;
	public Material material;

	// Use this for initialization
	void Start () {

		map = gameObject;

		foreach(Transform t1 in transform){
			foreach(Transform t2 in t1){
				t1.GetComponent<SpriteRenderer> ().material = material;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
