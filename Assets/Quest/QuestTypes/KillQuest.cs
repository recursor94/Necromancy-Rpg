using System;

/*
 * 
 * Defines behavior for quest requiring the killing of another npc or creature
 */
using System.Collections.Generic;


public sealed class KillQuest : Quest
{
	private Dictionary<string, int> killTargetInformation; //key is target id, int is kill count 
	public static Actor Participant; //must be static so works with base constructor
	public static string Name; //I have to make this static to use in super constructor call.  But this may very well not work correctly
	public KillQuest (string id, string name, Actor particpant, Dictionary<string,int> killTargetInformation) : base (id, Name, Participant) {

		Participant = participant;

		Name = name;

		base.name = name;//temporary fix:  bad idea FIX THIS
		this.killTargetInformation = killTargetInformation;

        int i = 0;
		foreach(var killTarget in killTargetInformation) {
			KillObjective objective = new KillObjective ("KillObjective" + killTarget.Key,  killTarget.Key, killTarget.Value); //setup all objectives with appropriate kill target.
			questObjectives.Add (objective);
            i++;
		}

	}

	protected override void OnEvent (GameEvent gameEvent) {
//
//		if(gameEvent is DeathEvent) {
//			foreach(KillObjective objective in questObjectives) {
//
//				objective.sendDeathEvent ((DeathEvent) gameEvent);
//			}
//		}

	}
	protected override string getQuestObjective ()
	{
		return "";
	}

	public override string ToString ()
	{
		return base.ToString () + "[Kill Quest target id = " + killTargetInformation +"]";
	}



}		



