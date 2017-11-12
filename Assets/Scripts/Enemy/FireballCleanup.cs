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
	
	}

	void clean(){
		Destroy (gameObject);
	}
}

