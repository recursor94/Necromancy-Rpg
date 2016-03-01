using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public sealed class PlayerActor : Actor {

	private int xp; //keeps track of total xp gained per level

	public PlayerActor (List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) :
	base (combatMoveSet, characterName, level, healthCap, gender, id) {
		this.xp = 0;
		
	}



	public int Xp {
		get {
			return xp;
		}
	}

	public void GiveXp(int xp) {
		this.xp += xp;
		Debug.Log (xp + " Given.");
	}
}
