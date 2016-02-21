using UnityEngine;
using System.Collections;

public class BattleCalculator {



	public BattleCalculator() {

	}

	public Actor getWinner(Actor player, Actor enemy) {

		if(player.Health <=0) {

			return enemy;
		}
		else if(enemy.Health <= 0) {
			return player;
		}
		return null;

	}

	public void applyDamage(Actor target, CombatAbility combatMove) {

		target.damage (combatMove.BaseDamage);
	}

}
