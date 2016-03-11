using UnityEngine;
using System.Collections;

public class KillObjectiveUpdateEvent : ObjectiveCompleteEvent {

    private string killedActorId;
    private int numberKilled;
    public KillObjectiveUpdateEvent(string objectiveId, string killedActorId, int numberKilled) : base(objectiveId) {
        this.killedActorId = killedActorId;
        this.numberKilled = numberKilled;
    }

    public string KilledActorId {
        get { return killedActorId; }
    }

    public int NumberKilled {
        get { return numberKilled; }
    }


}
