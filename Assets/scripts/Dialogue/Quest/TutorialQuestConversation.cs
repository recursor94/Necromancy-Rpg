﻿/*
 * Quest dialogue representing 
 * the beginning tutorial conversation introducing quest
 */
using UnityEngine;
using System.Collections;

public class TutorialQuestConversation : Conversation {

	private static string dialogueText = "There's zombies in that other room! " +
	                                     "Go kill that nonsense for me.";
	public TutorialQuestConversation() : base(dialogueText) {

		Actor TutorialNpc = new TutorialQuestGiverActor ();
		base.addValidNpcId (TutorialNpc.Id);
	}

}
