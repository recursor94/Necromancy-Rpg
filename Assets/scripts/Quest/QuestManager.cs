using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour {

	// Use this for initialization
	public static GameObject QuestController = new GameObject(); //Main controller for quest scripts 
	private static List<Quest> ActiveQuests;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		foreach(Quest q in ActiveQuests) {

			q.Update ();
		}
	
	}

	public static void startQuest (Quest q) {

		ActiveQuests.Add (q);
		q.Start ();
		DialogueController.ActiveConversations.AddRange (q.Conversations);


	}
}
