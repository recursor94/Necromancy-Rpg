using UnityEngine;
using System.Collections;

/*Contains list of all active quests and ways to send an event to every active quest or quest of a certain type
*/
using System.Collections.Generic;


public class QuestEventHandler  {


	private static List<Quest> ActiveQuests = new List<Quest>();
    private static Dictionary<string, object> QuestVars = new Dictionary<string, object>(); //dictionary containing every quest variable defined in quest scripts
    private static List<ObjectiveCompleteEvent> ObjectiveUpdateEvents; //Keeps track of all of the active events. This should be removed from when finished

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
            quest.SendEvent(e);
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

    public static int GetQuestInteger(string varName) {

        object value;
        QuestVars.TryGetValue(varName, out value);

        return (int) value;
      }

    public static bool GetQuestBoolean(string varName) {
        /*get specified boolean from the list of active quest variables
        */

        object value;
        QuestVars.TryGetValue(varName, out value);
        return (bool)value;
    }

    public static string GetQuestString(string varName) {
        /*
        get specified string from the list of active quest variables
        */

        object value;
        QuestVars.TryGetValue(varName, out value);
        return (string)value;

    }

    public static ObjectiveCompleteEvent FindEventById(string id) {
       foreach(ObjectiveCompleteEvent e in ObjectiveUpdateEvents) {
            if (e.ObjectiveId.Equals(id)) {
                ObjectiveCompleteEvent found = e;
                ObjectiveUpdateEvents.Remove(e);

                return found;
            }
        }
        return null;
    }


}
