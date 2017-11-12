using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOAL : FlammableObject {

	public override void onLit(){
		base.onLit ();
		EnemyController.clearEnemies ();
		Invoke ("onExtinguish", 2);
	}

	public override void onExtinguish(){
		base.onExtinguish ();
		Destroy (gameObject);
		FlammableObjects.Remove (this);
	}

	public override float ExtinguishProbability(){
		return 0f;
	}
}
