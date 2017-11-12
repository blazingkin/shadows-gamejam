using UnityEngine;
using System.Collections;

public class PositionMath
{

	public static Vector3 getMouseLocation(){
		float x = (Input.mousePosition.x * GlobalConstants.MapWidth) / Screen.width;
		x *= 2;
		x -= GlobalConstants.MapWidth;
		float y = (Input.mousePosition.y * GlobalConstants.MapHeight) / Screen.height;
		y *= 2;
		y -= GlobalConstants.MapHeight;
		return new Vector3 (x, y);
	}

	public static Vector3 getPlayerPosition(){
		return GameObject.FindWithTag ("Player").transform.position;
	}

	public static Vector3 findLocationToSpawn(int counter){
		float x, y;
		x = Random.Range (-GlobalConstants.MapWidth, GlobalConstants.MapWidth);
		y = Random.Range (-GlobalConstants.MapHeight, GlobalConstants.MapHeight);
		Vector3 Position = new Vector3(x, y);
		if (!LightSource.InLight (Position)) {
			return Position;
		}
		if (counter > 100) {
			return Position;
		}
		return findLocationToSpawn (counter + 1);
	}

	public static bool playerInteractedWith(Vector3 location){
		if (Input.GetMouseButtonDown (1)) {
			Vector3 mousePos = PositionMath.getMouseLocation();
			if ((location - mousePos).magnitude < GlobalConstants.InteractionDistance) {
				if ((getPlayerPosition () - location).magnitude < GlobalConstants.PlayerInteractionDistance) {
					return true;
				}
			}
		}
		if(Input.GetKeyDown (KeyCode.Space)){
			if ((getPlayerPosition () - location).magnitude < GlobalConstants.PlayerInteractionDistance) {
				return true;
			}
		}
		return false;
	}

}

