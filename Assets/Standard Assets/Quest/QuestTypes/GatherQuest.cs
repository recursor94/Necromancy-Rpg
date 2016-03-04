using System;
using System.Collections.Generic;


public class GatherQuest : Quest
	{

	public GatherQuest(string name, Actor particpant, List<QuestObjective> questObjectives, List<Conversation> conversations) : base(name, particpant, questObjectives, conversations){
	}


		protected override string getQuestObjective ()
		{
			throw new NotImplementedException ();
		}

	protected override void OnEvent (GameEvent e)
	{
		foreach(QuestObjective objective in questObjectives) {
		
			objective.sendEvent (e);
		}
	}
	}

