using UnityEngine;
using System.Collections;
using System.Collections.Generic;


 public class enemy : Actor { 

	private int baseXp; //unmodified xp granted when defeated
	private  Dictionary<GameItem, int> droppableItems;  //list of items that can be dropped from the enemy. along with corresponding probability of being dropped.

//	protected int levelOffset; //Determines the offset of the enemy's level to the player
	public enemy(List<CombatAbility> combatMoveSet, string characterName, int level, int healthCap, Gender gender, string id) : 
	base(combatMoveSet, characterName, level, healthCap, gender, id) {
		
	}
	public int BaseXp {get; set;}


	public void AddDroppableItem(GameItem item) {
		//add droppable item with 100 percent drop rate
		droppableItems.Add (item, 100);
	}
	public void AddDroppableItem(GameItem item, int dropChance) {
		//Add droppable item with a specified drop chance
	}


	


}
