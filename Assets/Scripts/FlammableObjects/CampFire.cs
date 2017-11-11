using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : FlammableObject {

	public Sprite litSprite;
	public Sprite extinguishedSprite;

	public override void onLit(){
		lightSource = new LightSource(lightObject, BrightRadius, DimRadius);
	}

	public override void onExtinguish(){
		if (null != lightSource) {
			lightSource.Extinguish();
		}
		lightSource = null;
	}

	public override void Update(){
		base.Update ();
		if (null == lightSource || !lightSource.lit) {
			GetComponent<SpriteRenderer> ().sprite = extinguishedSprite;
		} else {
			GetComponent<SpriteRenderer> ().sprite = litSprite;
		}
	}
}
