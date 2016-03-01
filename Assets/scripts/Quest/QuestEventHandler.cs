using UnityEngine;
using System.Collections;

/*Contains list of all active quests and ways to send an event to every active quest or quest of a certain type
*/
using System.Collections.Generic;


public class QuestEventHandler  {


	private static List<Quest> ActiveQuests = new List<Quest>();

	public static void AddActiveQuest(Quest q) {
		ActiveQuests.Add (q);
	}

	public static void sendQuestEvent(GameEvent e) {

		/*
		 * sends an event to every quest in the game,
		 * the appropriate quests will respond to it.
		 * kind of sloppy but it should work
		 */
		Debug.Log ("Number of Active Quests: " + ActiveQuests.Count);
		foreach(Quest quest in ActiveQuests) {
			quest.SendEvent (e);
			quest.ComputeComplete ();
		}
	}

}
