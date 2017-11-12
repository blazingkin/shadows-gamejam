using UnityEngine;
using System.Collections;

public class FireballCleanup : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Invoke ("clean", GlobalConstants.FireballLifeTime);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (LightSource.InLight (gameObject.transform.position)) {
			Destroy (gameObject);
		}
	}

	void clean(){
		Destroy (gameObject);
	}
}

