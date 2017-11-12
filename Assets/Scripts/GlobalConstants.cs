using UnityEngine;
using System.Collections;

public class GlobalConstants
{

	public static float MapWidth = 16f;



	public static float MapHeight = 9f;


	public static float GameLength = 2f; // Minutes


	public static float PlayerSpeed = 1f;


	public static float PlayerStoppingDist = 0.2f;


	public static float PlayerInteractionDistance = 1f;

	public static int PlayerStartingMatches = 3;
	public static float PlayerStartingHealth = 3;

	public static float InteractionDistance = 1f;


	public static float EndMoonPos = 15.5f;

	public static Vector2 FirstMatchPos = new Vector2(-MapWidth + .4f, -MapHeight + .4f);
	public static float MatchSpacing = .4f;


	public static float playerDarkDPS = .1f;
	public static float enemyDamage = 1f;
	public static float healthInLightDPS = .25f;


	public static float startingMaskHeight = 903f;
	public static float startingMaskWidth = 45f;

}

