using UnityEngine;
using System.Collections;

public class ExplosiveTorch : FlammableObject
{

	public override void onLit(){
		base.onLit ();
		Invoke ("onExtinguish", 10);
	}

	public override void onExtinguish(){
		base.onExtinguish ();
		GameObject.Instantiate (Resources.Load ("Prefabs/ParticleEffects/Explosion"), gameObject.transform.position, Quaternion.identity);
		if ((PositionMath.getPlayerPosition() - gameObject.transform.position).magnitude < GlobalConstants.torchExplosionRadius){
			PlayerData.Damage(0.5f);
		}
	}

	public override float ExtinguishProbability(){
		return 0f;
	}


}

