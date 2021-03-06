﻿/* 
* Base Actor script--representing players, npcs, and anything else meant to 
* interact with either the player or the environment in some fashion
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Actor {
	private List<CombatAbility> combatMoveSet; //represents all of the combat moves actor is capable of. dictionary so it can be added to and removed from
	//Is combatable?

	private string characterName; //represents the in game name of the character.

	protected int level; //represents level of character
	protected int damageModifier; //amount of damage added or subtracted to the base damage of every attack actor knows
	public enum Gender {
		MALE,
		FEMALE,
		ASEXUAL
	} //represents characters gender, asexual should only be used for non human characters

	private Gender gender;
	private int healthCap; //represents maximum health of actor, health can not be set above this value 

	private int health;
	private string id;

	protected Actor(List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender) {
        this.characterName = characterName;
		this.combatMoveSet = combatMoveSet;
		this.level = level;
		this.gender = gender;
		this.healthCap = healthCap; 
		this.health = healthCap; //character starts at full health.  May change in the future for special encounters
		this.id = Guid.NewGuid ().ToString ();
		damageModifier = level;
	}
	protected Actor(List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) {
        this.characterName = characterName;
		this.combatMoveSet = combatMoveSet;
		this.level = level;
		this.gender = gender;
		this.healthCap = healthCap; 
		this.health = healthCap; //character starts at full health.  May change in the future for special encounters
		this.id = id;
		damageModifier = level;
	}
	public int Health{ get { return health;
		}}

	public void damage(int magnitude) {
		health -= magnitude;
	}
	public List<CombatAbility> CombatMoveSet {get {return combatMoveSet;}}

	public string Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}

	public string CharacterName {
		get {
			return characterName;
		}
	}

	public int DamageModifier {
		get {
			//make sure damage modifier is updated before it's returned
			damageModifier = level;
			return damageModifier;
		}
	}

}
