using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public static List<GameObject> enemies = new List<GameObject> ();

	private Rigidbody2D rbody;
	private GameObject enemy;
	public float timePassed = 0f;
	public float timeToCheck = 0.75f;
	// Use this for initialization
	void Start () {
		enemy = gameObject;
		rbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rbody.AddForce (new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
		timePassed += Time.deltaTime;
		if (timePassed > timeToCheck) {
			if (LightSource.InBrightLight (enemy.transform.position)) {
				enemy.GetComponent<SpriteRenderer> ().enabled = false;
			} else {
				enemy.GetComponent<SpriteRenderer> ().enabled = true;
			}
			timePassed = 0;
		}
	}

	public static void clearEnemies(){
		foreach (GameObject go in enemies) {
			Destroy (go);
		}
		enemies = new List<GameObject> ();
	}

}
