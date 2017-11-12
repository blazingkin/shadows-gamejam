using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour
{

	GameObject potion;
	// Use this for initialization
	void Start ()
	{
		potion = gameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (PositionMath.playerInteractedWith (potion.transform.position)) {
			PlayerData.RestoreHeart ();
			Destroy (potion);
		}
	}
}

