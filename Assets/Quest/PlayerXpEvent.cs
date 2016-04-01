using UnityEngine;
using System.Collections;

/*
 * Event that handles player xp gains.
 */
public class PlayerXpEvent  {

	private int xp; //number of xp to give to the player

	public PlayerXpEvent(int xp) {
		this.xp = xp;
	}

	public int Xp {
		get {
			return xp;
		}
	}
}
