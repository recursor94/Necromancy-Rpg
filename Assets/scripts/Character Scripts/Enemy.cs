using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : Actor {



//	protected int levelOffset; //Determines the offset of the enemy's level to the player
	public Enemy(Dictionary<string, CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender) : 
	base(combatMoveSet, characterName, level, healthCap, gender) {
		
	}

}
