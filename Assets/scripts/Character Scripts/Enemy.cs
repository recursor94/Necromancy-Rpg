using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy : Actor {



//	protected int levelOffset; //Determines the offset of the enemy's level to the player
	public enemy(List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) : 
	base(combatMoveSet, characterName, level, healthCap, gender, id) {
		
	}

}
