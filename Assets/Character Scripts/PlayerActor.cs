using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public sealed class PlayerActor : Actor {

	private ulong xp; //keeps track of total xp gained per level
	private ulong xpLevelThreshold; //keeps track of how much xp it takes to get to the next level.

	public PlayerActor (List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) :
	base (combatMoveSet, characterName, level, healthCap, gender, id) {
		this.xp = 0;
		xpLevelThreshold = getNextXpThreshold (); //default value at first level
		
	}



	public ulong Xp {
		get {
			return xp;
		}
	}

	public void GiveXp(ulong xp) {
		this.xp += xp;
		Debug.Log (xp + " Given.");

		if(xp >= xpLevelThreshold) {
			levelUp (); 
		}
	}

	public void levelUp() {
		/*increments player's level .
		 *  taking into account whether the player had greater xp than the threshold, and carrying that remainder over.
		 */
		ulong remainder = xp - xpLevelThreshold;
		level += 1;
		xp = remainder;
		xpLevelThreshold = getNextXpThreshold ();
	}

	private ulong getNextXpThreshold() {
		/*
		 * uses formula based on level to determine how much xp is needed to advance to the next level.
		 */
		return (ulong) Math.Pow (level + 1, 3);
	}
}
