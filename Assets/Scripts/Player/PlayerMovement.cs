using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	GameObject player;
	Rigidbody2D rbody;
	Vector3 target;
	// Use this for initialization
	void Start ()
	{
		player = gameObject;
		rbody = GetComponent<Rigidbody2D> ();
		target = player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			OnMouseDown ();
		}
		if ((target - player.transform.position).magnitude < GlobalConstants.PlayerStoppingDist) {
			rbody.velocity = Vector2.zero;
		}
	}

	void OnMouseDown(){
		float x = (Input.mousePosition.x * GlobalConstants.MapWidth) / Screen.width;
		x *= 2;
		x -= GlobalConstants.MapWidth;
		float y = (Input.mousePosition.y * GlobalConstants.MapHeight) / Screen.height;
		y *= 2;
		y -= GlobalConstants.MapHeight;
		target = new Vector3 (x, y);
		rbody.velocity = target - player.transform.position;
		rbody.velocity /= rbody.velocity.magnitude;
		rbody.velocity *= GlobalConstants.PlayerSpeed; 
	}
}

