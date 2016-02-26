using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerActor : Actor {

	public PlayerActor (List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) :
	base (combatMoveSet, characterName, level, healthCap, gender, id) {
		
	}

}
