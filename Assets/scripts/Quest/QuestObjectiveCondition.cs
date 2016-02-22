/* Defines the conditions for each A quest objective must be completed.
 * relies on existence of subtypes:  EG: Enemy Death
 */
using UnityEngine;
using System.Collections;

public class QuestObjectiveCondition  {

	private bool isFulfilled;


	public QuestObjectiveCondition() {
		isFulfilled = false;
	}

}
