using UnityEngine;
using System.Collections;

public class PlayerActorFactory : ActorFactory{


	public override Actor CreateActor (System.Collections.Generic.List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Actor.Gender gender, string id)
	{
		return new PlayerActor(combatMoveSet, characterName, level, healthCap, gender, id) ;
	}
}
