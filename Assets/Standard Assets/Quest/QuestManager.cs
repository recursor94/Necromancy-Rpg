using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour {

	// Use this for initialization
	private static List<Quest> ActiveQuests = new List<Quest>();
	public static GameObject ControllerObject;
	void Start () {

		//FIX LATER: create initial quest, tutorial quest.


		ControllerObject = gameObject;
//		StartQuest (new TutorialQuest ());


	}
	
	// Update is called once per frame
	void Update () {

//	foreach(Quest q in ActiveQuests) {
//
//			if(q != null) {
//			q.Update (); //Probably terrible idea because now quest code 
//			//will have to execute sequentially--REMEMBER TO CHANGE QUESTS BACK TO 
//			//SCRIPTS LATER
//			}
//		} 
	
	}

	public static void StartQuest (Quest q) {

		Debug.Log (q);
		ActiveQuests.Add (q);
		//q.Start ();
		Debug.Log (q.Conversations.Count);
		DialogueController.ActiveConversations.AddRange (q.Conversations);

	//	QuestManager.ControllerObject.AddComponent<typeof(quest);




	}
}
