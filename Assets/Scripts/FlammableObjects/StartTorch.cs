using UnityEngine;
using System.Collections;

public class StartTorch : FlammableObject
{

	public override void onLit(){
		base.onLit ();
		Invoke("onExtinguish", GlobalConstants.StartingTorchLife);
	}

	public override void onExtinguish(){
		base.onExtinguish ();
	}

	public override float ExtinguishProbability(){
		return 0.8f;
	}
}

