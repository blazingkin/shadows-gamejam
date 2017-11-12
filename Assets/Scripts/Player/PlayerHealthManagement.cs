using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManagement : MonoBehaviour {

	public GameObject canvas;
	float width;
	public bool healthChanged;
	public float health;

	// Use this for initialization
	void Start () {
		PlayerData.SetHM (this);
	}

	// Update is called once per frame
	void Update () {
		if(healthChanged){
			width = HealthToWidth (health);
			canvas.GetComponent<RectTransform> ().sizeDelta = new Vector2(width, GlobalConstants.startingMaskWidth);
			healthChanged = false;
		}
	}

	private static float HealthToWidth(float health){
		return (GlobalConstants.startingMaskHeight) * (health / GlobalConstants.PlayerStartingHealth);
	}

}

