using UnityEngine;
using System.Collections;

public class Wizard : EnemyController
{

	protected override void FixedUpdate(){
		base.FixedUpdate ();
		if (Random.Range (0f, 1f) < GlobalConstants.WizardShootProbability) {
			Vector3 position = gameObject.transform.position;
			GameObject fireball = GameObject.Instantiate (Resources.Load ("Prefabs/Projectiles/Fireball"), position, Quaternion.identity) as GameObject;
			Rigidbody2D rbody = fireball.GetComponent<Rigidbody2D> ();
			rbody.velocity = (PositionMath.getPlayerPosition () - position).normalized * GlobalConstants.FireballVelocity;
		}
	}
}

