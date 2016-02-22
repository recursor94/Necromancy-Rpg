/*
 * 
 * Defines quest behavior including dialogue control
 * 
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Quest : MonoBehaviour {

	// Use this for initialization

	private List<QuestObjective> questObjectives; //a list of all quest objectives a given quest has
	private Dictionary<string, Conversation> conversationDialogues; //A dictionary containing the name of the npc associated with the conversation, and the conversation
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isComplete() {
		/*
		 * tests whether quest is complete by cycling through 
		 * all quest objectives in the dictionary and testing 
		 * whether each is complete */
		foreach(QuestObjective objective in questObjectives) {

			if(!objective.IsComplete) {
				return false;
			}
		}
		return true;
	}

	protected void finish() {
		/*
		 * finishes quest, 
		 * doing all of the necessary cleanup
		 * and adding it to the player's quest completed
		 * journal
		 * 
		 * Can also call instantiate new, subsequent quest
		 */
		enabled = false; //disable quest script, so it no longer executes
	}


}
