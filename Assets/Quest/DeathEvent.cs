using UnityEngine;
using System.Collections;

public class DeathEvent : GameEvent {

	private Actor killedTarget; //represents the actor who was killed who initiated this event


	public DeathEvent(Actor killedTarget) {
		this.killedTarget = killedTarget;
	}

	public Actor KilledTarget {
		get {
			return killedTarget;
		}
	}
}
