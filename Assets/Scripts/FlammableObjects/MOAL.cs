using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOAL : FlammableObject {

	public Sprite litSprite;
	public Sprite extinguishedSprite;

	public override void onLit(){
		base.onLit ();
		GetComponent<SpriteRenderer> ().sprite = litSprite;
		Invoke ("onExtinguish", 2);
	}

	public override void onExtinguish(){
		base.onExtinguish ();
		Destroy (gameObject);
		FlammableObjects.Remove (this);
	}
}
