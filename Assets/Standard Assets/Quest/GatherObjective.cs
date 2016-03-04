using System;


public class GatherObjective : QuestObjective
	{

	private GameItem requiredItem; //the item required to be gathered for the objective to be complete
	private int itemCount; //the number of the item that must be gathered for the objective to be complete.

	public GatherObjective(string id, GameItem requiredItem, int itemCount) : base(id) {
		this.requiredItem = requiredItem;
		this.itemCount = itemCount;
	}

		
	public override void sendEvent (GameEvent e)
	{

	}

	public void sendGatherEvent(GatherEvent e) {
		if(e.GatheredItem.Equals (requiredItem)) {
			itemCount--;

			if(itemCount <= 0) {
				complete ();
			}
		}
	}
}


