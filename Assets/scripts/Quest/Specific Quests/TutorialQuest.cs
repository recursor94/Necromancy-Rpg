using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TutorialQuest : Quest{

	// Use this for initialization
	void Start () {

		Debug.Log (PlayerInformation.PlayerActor.Id);
		Debug.Log("Tutorial Quest Initialized");

		questObjectives = new List<QuestObjective> ();
		conversations = new List<Conversation> ();
		conversations.Add (new TutorialQuestConversation());
		base.Start ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
