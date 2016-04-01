using UnityEngine;
using System.Collections;

public class CombatAbilityBasic : CombatAbility {

	public static string ABILITY_NAME = "Attack"; //define magic values here
	public static int BASE_DAMAGE = 50;
	public CombatAbilityBasic() : base(ABILITY_NAME, BASE_DAMAGE) {
		

	}
}
