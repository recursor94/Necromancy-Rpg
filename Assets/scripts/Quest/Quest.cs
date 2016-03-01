/*
 * 
 * Defines quest behavior including dialogue control
 * 
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Quest {

	// Use this for initialization

	protected Actor participant; //Added participant actor to keep quest code independent of player
	protected List<QuestObjective> questObjectives; //a list of all quest objectives a given quest has
	protected List<Conversation> conversations;
	protected string name; //name of quest
	protected bool isComplete;

	protected Quest(string name, Actor particpant, List<QuestObjective> questObjectives, List<Conversation> conversations) {

		this.name = name;
		this.participant = particpant;
		this.questObjectives = questObjectives;
		this.conversations = conversations;
	}

	protected Quest(string name, Actor participant) {
		this.name = name;
		this.participant = participant;
		this.questObjectives = new List<QuestObjective> ();
		this.conversations = new List<Conversation> ();
	}

	public bool IsComplete() {
		/*
		 * tests whether quest is complete by cycling through 
		 * all quest objectives in the dictionary and testing 
		 * whether each is complete */
		foreach(QuestObjective objective in questObjectives) {

			if(!objective.IsComplete) {
				Debug.Log ("Objective not complete! " + objective + " Total Number of Objectives: " + questObjectives.Count);
				return false;
			}
		}
		Debug.Log ("All objectives complete!");
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
	}

	protected abstract void OnEvent(GameEvent e); //defines behavior when an event is triggered in game such as target npc killed.  responds appropriately

	public  List<Conversation> Conversations {
		get {
			return conversations;
		}
	}

	protected abstract string getQuestObjective(); //Returns quest Objective string for quest
	public void SendEvent(GameEvent e) {
		foreach(QuestObjective objective in questObjectives) {
			objective.sendEvent (e); 
		}
	} 

	public void ComputeComplete() {
		//computes whether the quest is complete
		Debug.Log ("Computing if quest is complete");
		if(IsComplete()) {
			this.isComplete = true;
			Debug.Log ("Quest complete!");
		}

	}

	public override string ToString ()
	{
		return "Name: " + name + "\tNumber of Conversations: " + conversations.Count + "\t Number of objectives: "
		+ questObjectives.Count;
	}
		
	
}
