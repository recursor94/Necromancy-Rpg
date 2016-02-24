/* 
* Base Actor script--representing players, npcs, and anything else meant to 
* interact with either the player or the environment in some fashion
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Actor {
	private Dictionary<string, CombatAbility> combatMoveSet; //represents all of the combat moves actor is capable of. dictionary so it can be added to and removed from
	//Is combatable?

	private string characterName; //represents the in game name of the character.

	private int level; //represents level of character
	public enum Gender {
		MALE,
		FEMALE,
		ASEXUAL
	} //represents characters gender, asexual should only be used for non human characters

	private Gender gender;
	private int healthCap; //represents maximum health of actor, health can not be set above this value 

	private int health;
	private string id;

	protected Actor(Dictionary<string, CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender) {
		this.combatMoveSet = combatMoveSet;
		this.level = level;
		this.gender = gender;
		this.healthCap = healthCap; 
		this.health = healthCap; //character starts at full health.  May change in the future for special encounters
		this.id = Guid.NewGuid ().ToString ();
	}
	protected Actor(Dictionary<string, CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) {
		this.combatMoveSet = combatMoveSet;
		this.level = level;
		this.gender = gender;
		this.healthCap = healthCap; 
		this.health = healthCap; //character starts at full health.  May change in the future for special encounters
		id = Guid.NewGuid ().ToString ();
	}
	public int Health{ get { return health;
		}}

	public void damage(int magnitude) {
		health -= magnitude;
	}
	public Dictionary<string, CombatAbility> CombatMoveSet {get {return combatMoveSet;}}

	public string Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}
}
