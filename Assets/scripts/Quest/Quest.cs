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
}
