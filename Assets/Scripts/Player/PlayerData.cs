﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {

	public static GameObject playerObj;
	public static int Matches = GlobalConstants.PlayerStartingMatches;
	public static float Health = GlobalConstants.PlayerStartingHealth;

	public static bool useMatch(){
		if (Matches <= 0) {
			return false;
		}
		Matches--;
		return true;
	}

	public static void initialize(){
		Matches = GlobalConstants.PlayerStartingMatches;
		Health = GlobalConstants.PlayerStartingHealth;
	}

}
