using UnityEngine;
using System.Collections;

public class SpeedPotion : MonoBehaviour
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
			PlayerData.SpeedMultiplier *= 2;
			potion.SetActive (false);
			Invoke ("RestoreSpeed", GlobalConstants.SpeedPotionTime);
		}
	}

	void RestoreSpeed(){
		PlayerData.SpeedMultiplier = 1;
		Destroy (potion);
	}

}

