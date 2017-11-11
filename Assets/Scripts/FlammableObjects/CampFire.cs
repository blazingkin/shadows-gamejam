using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : FlammableObject {

	public Sprite litSprite;
	public Sprite extinguishedSprite;

	public override void onLit(){
		base.onLit ();
		GetComponent<SpriteRenderer> ().sprite = litSprite;
	}

	public override void onExtinguish(){
		base.onExtinguish ();
		GetComponent<SpriteRenderer> ().sprite = extinguishedSprite;
	}

}
