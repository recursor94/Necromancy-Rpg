using System;

/*
 * 
 * Defines behavior for quest requiring the killing of another npc or creature
 */
public class KillQuest : Quest
{
	private string killTargetId;
	public static Actor Participant; //must be static so works with base constructor
	public KillQuest (Actor particpant, string killTargetId) : base (Participant) {

		Participant = participant;
		this.killTargetId = killTargetId;
	}

	protected override void OnEvent (GameEvent gameEvent) {

		if(gameEvent is DeathEvent) {
			foreach(KillObjective objective in questObjectives) {

				objective.sendDeathEvent ((DeathEvent) gameEvent);
			}
		}

	}




}		



