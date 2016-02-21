using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerActor : Actor{


	private static Dictionary<string, CombatAbility> combatAbilities = new Dictionary<string, CombatAbility>();
	//must be static otherwise can not be used in base constructor.

	public PlayerActor () :
	base (combatAbilities, PlayerInformation.CharacterName, PlayerInformation.Level, PlayerInformation.HealthCap, PlayerInformation.Gender)
	{
		CombatAbilityBasic basicAttack = new CombatAbilityBasic ();

		combatAbilities.Add (basicAttack.Name, basicAttack);
	}

}
