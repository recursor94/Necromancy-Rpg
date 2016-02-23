using System;

/*
 * 
 * Defines behavior for quest requiring the killing of another npc or creature
 */
public class KillQuest : Quest
{
	private static Actor Participant;
	private Actor killTarget;
	public KillQuest (Actor killTarget) : base (Participant) {

		this.killTarget = killTarget;
	}

	protected override void OnEvent (GameEvent gameEvent) {

		if(gameEvent is DeathEvent) {
			foreach(QuestObjective objective in questObjectives) {
				
			}
		}

	}




}		



