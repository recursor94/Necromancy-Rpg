using UnityEngine;
using System.Collections;
using System.Collections.Generic;


 public class Enemy : Actor { 

	private ulong baseXp; //unmodified xp granted when defeated
	private  Dictionary<GameItem, int> droppableItems;  //list of items that can be dropped from the enemy. along with corresponding probability of being dropped.

//	protected int levelOffset; //Determines the offset of the enemy's level to the player
	public Enemy(List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id, ulong baseXp) : 
	base(combatMoveSet, characterName, level, healthCap, gender, id) {

		droppableItems = new Dictionary<GameItem, int> ();
		this.baseXp = baseXp;
	}



	public void AddDroppableItem(GameItem item) {
		//add droppable item with 100 percent drop rate
		droppableItems.Add (item, 100);
	}
	public void AddDroppableItem(GameItem item, int dropChance) {
		//Add droppable item with a specified drop chance
	}

	public ulong getGrantableXp() {
		/*takes base xp, multiplies it by level, and in future modifies based on player level.
		 */

		return baseXp * (ulong)level;
	}


	


}
