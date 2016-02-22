/*
 * Defines object that contains state for a conversation
 * including the text in that conversation
 * and the characters who are valid initiator's of that conversation
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Conversation {

	private List<string> validNpcIds; //list of npc id's that are elligible for this conversation
	private string dialogueText; //very simple for now--one string representing the whole dialogue


	public Conversation(string dialogueText, List<string> validNpcIds) {
		this.dialogueText = dialogueText;
		this.validNpcIds = validNpcIds;
	}

	public Conversation(string dialogueText) {
		this.dialogueText = dialogueText;
		this.validNpcIds = new List<string> ();
	}

	public void addValidNpcId(string guid) {
		/*
		 * adds the unique id of an npc
		 * to the list of valid npcs for this conversation
		 */
		validNpcIds.Add (guid);
	}

	public bool isNpcValid(string guid) {
		return validNpcIds.Contains (guid);
	}

}
