using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueController : MonoBehaviour {

	public static List<Conversation> ActiveConversations;
	// Use this for initialization
	void Start () {
		ActiveConversations = new List<Conversation> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void AddActiveConversation(Conversation c) {
	
		ActiveConversations.Add (c);
	}

	public static Conversation getValidConversation(string guid) {
		/*
		 * returns the first valid conversation for the npc
		 * may make this based on a priority system later,
		 * but there should not be more than one valid conversation for an npc 
		 * at any given time for now
		 */

		foreach(Conversation conversation in ActiveConversations) {

			if(conversation.isNpcValid (guid)) {
				return conversation;
			}
		}
		return null;
	}
}
