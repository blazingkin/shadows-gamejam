using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameEvent {

	string EventName();
	float EventProbability();
	void OnEvent();

}
