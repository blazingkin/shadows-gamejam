using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

	GameObject map;
	public Material material;

	// Use this for initialization
	void Start () {

		map = GameObject.Instantiate (Resources.Load("Prefabs/Map"), new Vector2(0, 0), Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
