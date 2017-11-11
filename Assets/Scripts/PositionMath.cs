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

}

