using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchUIManager : MonoBehaviour {

	static List<GameObject> MatchUIElements = new List<GameObject>();

	// Use this for initialization
	void Start () {
		clear ();
		for (int i = 0; i < PlayerData.Matches; i++) {
			addMatch ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (MatchUIElements.Count != PlayerData.Matches) {
			while (PlayerData.Matches > MatchUIElements.Count) {
				addMatch ();
			}
			while (PlayerData.Matches < MatchUIElements.Count) {
				removeMatch ();
			}
		}
	}

	static void addMatch(){
		Vector2 position = new Vector2 (GlobalConstants.FirstMatchPos.x, GlobalConstants.FirstMatchPos.y);
		position.x += (MatchUIElements.Count * GlobalConstants.MatchSpacing);
		GameObject match = GameObject.Instantiate (Resources.Load ("Prefabs/UI/MatchUI"), position, Quaternion.identity) as GameObject;
		MatchUIElements.Add (match);
	}

	static void removeMatch(){
		GameObject last = MatchUIElements [MatchUIElements.Count - 1];
		MatchUIElements.Remove (last);
		Destroy (last);
	}

	public static void clear(){
		while (MatchUIElements.Count > 1) {
			removeMatch ();
		}
		MatchUIElements = new List<GameObject> ();
	}
}
