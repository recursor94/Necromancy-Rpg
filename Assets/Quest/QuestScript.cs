using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NLua;

public class QuestScript {

    protected Quest quest;
    protected int currentStage;
    private static List<QuestVariable<object>> questVars; //structure for representing name of quest variable and value of it.  We don't know how many or what types they're going to hold.
    public QuestScript(Quest quest) {
        this.quest = quest;
        currentStage = quest.Stage;
        questVars = new List<QuestVariable<object>>();
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    protected static void AddQuestVariable(string varName, object value) {
        /*
        Add a quest variable along with a value
        */
        QuestVariable<object> variable = new QuestVariable<object>(varName, value);
        questVars.Add(variable);
    }

    protected void UpdateQuestVariable(QuestVariable<object> variable, object value) {

        questVars[questVars.IndexOf(variable)].Value = value;

    }

    public static bool TryGetQuestVariableValue(string varName, out int result) {
        foreach(QuestVariable<object> variable in questVars) {
            if (variable.VarName.Equals(varName)) {
                result = (int)variable.Value; //not safe if wrong type, fix later
                return true;
            }
        }
        result = default(int);
        return false;  
    }
    public static bool TryGetQuestVariableValue(string varName, out string result) {
        foreach(QuestVariable<object> variable in questVars) {
            if (variable.VarName.Equals(varName)) {
                result = (string)variable.Value; //not safe if wrong type, fix later
                return true;
            }
        }
        result = default(string);
        return false;  
    }
    public static bool TryGetQuestVariableValue(string varName, out bool result) {
        foreach(QuestVariable<object> variable in questVars) {
            if (variable.VarName.Equals(varName)) {
                result = (bool)variable.Value; //not safe if wrong type, fix later
                return true;
            }
        }
        result = default(bool);
        return false;  
    }
    public static bool TryGetQuestVariableValue(string varName, out double result) {
        foreach(QuestVariable<object> variable in questVars) {
            if (variable.VarName.Equals(varName)) {
                result = (double)variable.Value; //not safe if wrong type, fix later
                return true;
            }
        }
        result = default(double);
        return false;  
    }
}
