using System;
using System.Collections.Generic;


public class EnemyActorFactory : ActorFactory {

	public override Actor CreateActor(List <CombatAbility>  combatMoveSet, string characterName, int level, int healthCap, Actor.Gender gender, string id)
	{
		return new Enemy(combatMoveSet, characterName, level, healthCap, gender, id);
	}
}


