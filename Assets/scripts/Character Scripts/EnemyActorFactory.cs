using System;


public class EnemyActorFactory : ActorFactory {

	public override Actor CreateActor (System.Collections.Generic.Dictionary<string, CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Actor.Gender gender, string id)
	{
		return new EnemyActorFactory (combatMoveSet, characterName, level, healthCap, gender, id);
	}
}


