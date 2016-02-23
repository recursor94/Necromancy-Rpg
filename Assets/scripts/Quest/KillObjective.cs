using UnityEngine;
using System.Collections;

/*
 * quest objective for tracking whether npc was killed.
 * and a number of npc to kill
*/
public sealed class KillObjective : QuestObjective  {


	private string actorTargetId; //string representing in game id of actor to be killed;
	private int requiredKillCount; //int representing how many of the target actor need to be kiled.


	public KillObjective(string actorTargetId) {

		this.actorTargetId = actorTargetId;
		this.requiredKillCount = 1; //by default only one will probably exist/need to be killed
		this.ObjectiveText = actorTargetId;
	}

	public KillObjective(string actorTargetId, int requiredKillCount) {

		//Constructor called if there are more than one of the target actor
		//existing in the game world, and more than one needs to be killed
		this.actorTargetId = actorTargetId;
		this.requiredKillCount = requiredKillCount;
	}

	
}
