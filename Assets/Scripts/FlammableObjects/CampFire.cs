using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : FlammableObject {
	
	public override void onLit(){
		base.onLit ();

	}

	public override void onExtinguish(){
		base.onExtinguish ();
	}

	public override void Update(){
		timePassed += Time.deltaTime;
		if (PositionMath.playerInteractedWith (transform.position)) {
			if (lightSource == null || lightSource.lit == false) {
				if (PlayerData.Matches >= 2 && PlayerData.useMatch () && PlayerData.useMatch()) {
					onLit ();
				}
			}
		}
	}

	public override float ExtinguishProbability(){
		return 0.75f;
	}

}
