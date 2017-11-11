using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : FlammableObject {

	new public void onLit(){
		lightSource = new LightSource(lightObject, BrightRadius, DimRadius);
	}

}
