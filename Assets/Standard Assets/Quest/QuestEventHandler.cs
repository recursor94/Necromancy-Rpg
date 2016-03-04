using UnityEngine;
using System.Collections;

/*Contains list of all active quests and ways to send an event to every active quest or quest of a certain type
*/
using System.Collections.Generic;


public class QuestEventHandler  {


	private static List<Quest> ActiveQuests = new List<Quest>();
    private static Dictionary<string, object> QuestVars = new Dictionary<string, object>(); //dictionary containing every quest variable defined in quest scripts

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

    public static void AddQuestVar(string varName, object value) {

        /*
        Method called by quest scripts to add a variable and it's value to the dictionary of 
        active quest variables
        */
        QuestVars.Add(varName, value);
    }

    public static int getQuestInteger(string varName) {

        object value;
        QuestVars.TryGetValue(varName, out value);

        return (int) value;
      }

}
