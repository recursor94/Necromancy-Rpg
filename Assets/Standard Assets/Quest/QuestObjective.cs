using UnityEngine;
using System.Collections;
/*
 * represents all quest objectives and 
 * contains state for whether each objective is complete
 * can also update or change objective without completing it.
 * 
 */
public abstract class QuestObjective  {

	private bool isComplete;
	private string objectiveText;
    private string id;

	public QuestObjective(string id) {
		isComplete = false;
        this.id = id;

	}
	public bool IsComplete {
		get {
			return isComplete;
		}
	}

	public override string ToString ()
	{
		if(isComplete) {

			return ObjectiveText + ": " + "[Complete!]";

		}
		else {
			return ObjectiveText + ": [Incomplete]";
		}
	}

	public string ObjectiveText {
		//in protected method because should not be accessed outside of class
		//or sub classes but behavior might change
		get {
			return objectiveText;
		}
		set {
			objectiveText = value;
		}

	}
	public abstract void sendEvent (GameEvent e);

	protected void complete() {
		//sets iscomplete to true and calls on complete

		onComplete ();
	}
	protected void onComplete() {
		//Event called on the complete of the objective
		isComplete = true;
		Debug.Log ("Objective Complete!");
	}
    protected abstract void OnUpdate(); //method for controlling what happens when objective is updated but not completed.  EG.  an enemy is killed, but not all of the enemies required have been killed
    public string Id {
        get { return id; }
    }

}
