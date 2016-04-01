TutorialQuestScript = {}
local skeletonsKilled = 0

local function determineStageChange()
    if (skeletonsKilled == 1) then
        changeStage(10)
        return
    elseif (skeletonsKilled == 2) then
        changeStage(20)
        return
    end
end

function TutorialQuestScript:init(quest)
    QuestScript.init(self, quest)
end

function TutorialQuestScript:OnUpdate()
    Debug.Log("Skeletons Killed: " .. skeletonsKilled)
    DetermineStageChange()
    QuestScript.onUpdate(self) --Call to super
end

function TutorialQuestScript:OnStageChange(stage)
    Debug.Log("New Stage: " .. stage)
end
