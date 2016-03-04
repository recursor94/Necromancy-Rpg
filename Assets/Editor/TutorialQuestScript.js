#pragma strict

class TutorialQuestScript extends QuestScript {
    /*
    Quest script for logic of tutorial quest.
    tutorial quest will have 3 stages and 
    have variables Representing all of the mobs that need to be killed.
    */
    var skeletonsSlain : int;
    function TutorialQuestScript(quest: KillQuest) {
        super(quest);

    }
    function Start () {

    }

    function Update () {
        Debug.Log(currentStage);
        super.Update();
        
    }

    function OnStageChange(stage: int) {

    }

}
