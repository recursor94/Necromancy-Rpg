using UnityEngine;
using System.Collections;

/*
An event object that's created every time an objective is updated.
*/
public abstract class ObjectiveCompleteEvent : GameEvent {
    private string objectiveId; //id of objective so that it can be identified by quest scripts

    public ObjectiveCompleteEvent(string objectiveId) {
        this.objectiveId = objectiveId;
    }
}
