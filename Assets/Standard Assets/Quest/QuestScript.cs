using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestScript {

    protected Quest quest;
    protected int currentStage;
    private static Dictionary<string, object> questVars; //structure for representing name of quest variable and value of it.  We don't know how many or what types they're going to hold.

    public QuestScript(Quest quest) {
        this.quest = quest;
        currentStage = quest.Stage;
        questVars = new Dictionary<string, object>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   protected void AddQuestVariable(string varName, object value) {
        /*
        Add a quest variable along with a value
        */
        questVars.Add(varName, value);
    } 

    protected void UpdateQuestVariable (string varName, object value) {

        questVars[varName] = value;

    }
}
