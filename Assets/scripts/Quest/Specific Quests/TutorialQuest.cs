using UnityEngine;
using System.Collections;

public class TutorialQuest : Quest{

	// Use this for initialization
	void Start () {

		Debug.Log (PlayerInformation.PlayerActor.Id);
		Debug.Log("Tutorial Quest Initialized");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
