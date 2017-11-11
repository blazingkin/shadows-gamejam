using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	GameObject player;
	Rigidbody2D rbody;
	Vector3 target;

	public GameObject idle, walking, playerLight;
	private bool right = true;

	// Use this for initialization
	void Start ()
	{
		player = gameObject;
		rbody = GetComponent<Rigidbody2D> ();
		target = player.transform.position;
		PlayerData.playerObj = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			OnMouseDown ();
		}
		if ((target - player.transform.position).magnitude < GlobalConstants.PlayerStoppingDist) {
			rbody.velocity = Vector2.zero;
			player.GetComponent<SpriteRenderer> ().sprite = idle.GetComponent<SpriteRenderer> ().sprite;
			player.GetComponent<Animator> ().runtimeAnimatorController = idle.GetComponent<Animator> ().runtimeAnimatorController;
		}
		if (!LightSource.InLight (player.transform.position)) {
			PlayerData.Damage (GlobalConstants.playerDarkDPS * Time.deltaTime);
		} else {
			PlayerData.Heal (GlobalConstants.healthInLightDPS * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D collision){
		if (!LightSource.InLight (player.transform.position)) {
			PlayerData.Damage (GlobalConstants.enemyDamage);
		}
	}

	void OnMouseDown(){
		target = PositionMath.getMouseLocation ();
		rbody.velocity = target - player.transform.position;
		rbody.velocity /= rbody.velocity.magnitude;
		rbody.velocity *= GlobalConstants.PlayerSpeed;
		if (target.x < player.transform.position.x) {
			if (right) {
				playerLight.transform.position = player.transform.position + new Vector3 (0, 0, .1f);
				player.transform.rotation = Quaternion.Euler (new Vector3 (180, 0, 180));
				right = false;
			}
		} else {
			if (!right) {
				playerLight.transform.position = player.transform.position + new Vector3 (0, 0, 0.1f);
				player.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
				right = true;
			}
		}
		player.GetComponent<SpriteRenderer> ().sprite = walking.GetComponent<SpriteRenderer> ().sprite;
		player.GetComponent<Animator> ().runtimeAnimatorController = walking.GetComponent<Animator> ().runtimeAnimatorController;
	}
}

