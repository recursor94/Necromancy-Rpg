using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TESTEnemyActor : Actor {

	public static Dictionary<string, CombatAbility> combatAbilities;
	public TESTEnemyActor() :
	base(combatAbilities, "TESTENEMY", 1, 100, Gender.ASEXUAL) {
		
	}



}
