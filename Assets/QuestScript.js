#pragma strict
import System.Collections.Generic; 
class QuestScript {

    protected var quest : Quest;
    protected var currentStage : int;
    protected var objectives : List.<QuestObjective>;

    function QuestScript(quest:Quest) {
        this.quest = quest;
        this.currentStage = quest.Stage;
        this.objectives = quest.QuestObjectives;

    }
    function Start () {

    }

    function Update () {

        if(currentStage != quest.Stage) {
            currentStage = quest.Stage;
            OnStageChange(quest.Stage);
        }

    }
    function OnStageChange(stage:int) {

    }

}
