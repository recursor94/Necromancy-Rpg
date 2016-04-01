using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class ActorFactory  {

	public abstract Actor CreateActor (List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Actor.Gender gender, string id);
}