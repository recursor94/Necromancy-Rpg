using UnityEngine;
using System.Collections;

public class BattleCalculator {



	public BattleCalculator() {

	}

	public Actor getWinner(Actor player, Actor enemy) {

		Debug.Log (enemy.Health);
		Debug.Log ((player.Health));
		if(player.Health <=0) {

			return   enemy;
		}
		else if(enemy.Health <= 0) {
			return player;
		}
		return null;

	}

	public void applyDamage(Actor target, CombatAbility combatMove, int damageModifier) {

		target.damage (combatMove.BaseDamage * damageModifier);
	}

}
