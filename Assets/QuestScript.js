#pragma strict

class QuestScript {

    var quest : Quest;
    var currentStage : int;

    function QuestScript(quest:Quest) {
        this.quest = quest;
        this.currentStage = quest.Stage;

    }
    function Start () {

    }

    function Update () {

        if(currentStage != quest.Stage) {
            currentStage = quest.Stage;
            OnStagechange(quest.Stage);
        }

    }
    function OnStagechange(stage:int) {

    }

}
