using UnityEngine;
using System.Collections;

public class ExplosiveTorch : FlammableObject
{

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

