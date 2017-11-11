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

	public override float ExtinguishProbability(){
		return 0.2f;
	}

}
