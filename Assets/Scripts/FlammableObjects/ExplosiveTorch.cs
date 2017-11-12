using UnityEngine;
using System.Collections;

public class ExplosiveTorch : FlammableObject
{

	public override void onLit(){
		base.onLit ();
		Invoke ("onExtinguish", 10);
	}

	public override void onExtinguish(){
		if (null != lightSource) {
			GameObject.Instantiate (Resources.Load ("Prefabs/ParticleEffects/Explosion"), gameObject.transform.position, Quaternion.identity);
			if ((PositionMath.getPlayerPosition() - gameObject.transform.position).magnitude < BrightRadius){
				PlayerData.Damage(0.5f);
			}
		}
		base.onExtinguish ();
	}

	public override float ExtinguishProbability(){
		return 0f;
	}


}

