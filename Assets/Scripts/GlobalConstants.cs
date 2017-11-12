using UnityEngine;
using System.Collections;

public class GlobalConstants
{

	public static float MapWidth = 16f;



	public static float MapHeight = 9f;


	public static float GameLength = 2f; // Minutes



	public static float PlayerSpeed = 1.7f;


	public static float PlayerStoppingDist = 0.2f;


	public static float PlayerInteractionDistance = 1.5f;

	public static int PlayerStartingMatches = 1;
	public static float PlayerStartingHealth = 3;

	public static float InteractionDistance = 1.5f;


	public static float EndMoonPos = 15.5f;

	public static Vector2 FirstMatchPos = new Vector2(-MapWidth + .4f, -MapHeight + .4f);
	public static float MatchSpacing = .4f;

	public static Vector2 GustOWindPos = new Vector2(-MapWidth, 0);
	public static Vector3 RainPos = new Vector3 (-12.4f, 6.9f, -.1f);
	public static Quaternion RainRotation = Quaternion.Euler(new Vector3(49.5f, 90f, 0f));

	public static float playerDarkDPS = .1f;
	public static float enemyDamage = 1f;
	public static float healthInLightDPS = .1f;


	public static float startingMaskHeight = 903f;
	public static float startingMaskWidth = 45f;

	public static int SpeedPotionTime = 5;

}

