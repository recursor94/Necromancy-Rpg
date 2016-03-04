using UnityEngine;
using System.Collections;
using System;

/*
 * quest objective for tracking whether npc was killed.
 * and a number of npc to kill
*/
public sealed class KillObjective : QuestObjective  {


	private string actorTargetId; //string representing in game id of actor to be killed;
	private int requiredKillCount; //int representing how many of the target actor need to be kiled.
	private int killedCount;


	public KillObjective(string objectiveId, string actorTargetId) : base(objectiveId) {

		this.actorTargetId = actorTargetId;
		this.requiredKillCount = 1; //by default only one will probably exist/need to be killed
		this.ObjectiveText = actorTargetId;
	}

	public KillObjective(string objectiveId, string actorTargetId, int requiredKillCount) :base (objectiveId) {

		//Constructor called if there are more than one of the target actor
		//existing in the game world, and more than one needs to be killed
		this.actorTargetId = actorTargetId;
		this.requiredKillCount = requiredKillCount;
	}

	private void incrementKillCount() {
		//increments the tally of the number of targets killed.
		killedCount++;
	}
	public void sendDeathEvent(DeathEvent deathEvent) {

		//respond to target actor's death
		Debug.Log ("Reminder Actor Target ID is: " + actorTargetId);
		Debug.Log ("Death Event" + deathEvent.ToString ());
		Debug.Log ("Sent Actor is: " + deathEvent.KilledTarget.Id);

		if(deathEvent.KilledTarget.Id.Equals(actorTargetId)) {

			incrementKillCount ();
			if(killedCount >= requiredKillCount) {

				complete ();
			}
		}
	}
	


	
	public override void sendEvent (GameEvent e)
	{
		Debug.Log ("SENDING EVENT TO KILL OBJECTIVE");
		if(e is DeathEvent) {
			Debug.Log ("Event is death event");

		sendDeathEvent ((DeathEvent) e);
		}
		else {
			Debug.Log("Event is not death event");
		}
	}

    protected override void OnUpdate() {
       
    }
}
