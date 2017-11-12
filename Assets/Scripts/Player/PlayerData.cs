using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {

	public static GameObject playerObj;
	public static int Matches = GlobalConstants.PlayerStartingMatches;
	public static float Health = GlobalConstants.PlayerStartingHealth;
	public static float SpeedMultiplier = 1;
	public static PlayerHealthManagement hm;

	public static void SetHM(PlayerHealthManagement healthManager){
		hm = healthManager;
	}

	public static bool useMatch(){
		if (Matches <= 0) {
			return false;
		}
		Matches--;
		return true;
	}

	public static void Damage(float damage){
		Health -= damage;
		if (Health <= 0) {
			UIManager.GameOver ();
		}
		hm.health = Health;
		hm.healthChanged = true;
	}

	public static void Heal(float amount){
		float max = Mathf.Ceil (Health);
		Health += amount;
		Health = Health > max ? max : Health;
		hm.health = Health;
		hm.healthChanged = true;
	}

	public static void RestoreHeart(){
		Health += 1;
		Health = Health > GlobalConstants.PlayerStartingHealth ? GlobalConstants.PlayerStartingHealth : Health;
		hm.health = Health;
		hm.healthChanged = true;
	}

	public static void initialize(){
		Matches = GlobalConstants.PlayerStartingMatches;
		Health = GlobalConstants.PlayerStartingHealth;
		SpeedMultiplier = 1;
	}



}
