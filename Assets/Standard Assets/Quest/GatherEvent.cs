using System;
/*
 * represents event when the player receives some kind of events
 */

	public class GatherEvent : GameEvent
{

	GameItem gatheredItem;
		
	public GatherEvent (GameItem gatheredItem) {

		this.gatheredItem = gatheredItem;
	}

	public GameItem GatheredItem {
		get {
			return gatheredItem;
		}
	}
}
