--Template for quest script code
--
local QuestScript = {} --module/class name

--instance data
QuestScript.prototype = {quest = {}, currentStage = 0}
--
local function setAsIndex(metaTable)
	--set this table as the parent (meta tables index) of the child quest script
	metaTable.__index = QuestScript.prototype
end

function QuestScript:makeScript(object, quest)
	--make script child of quest script
	metaTable = {}
	setAsIndex(metaTable)
	setmetatable(object, metatable)
	QuestScript.prototype.setQuest(object, quest)
        return object
end
	
function QuestScript.prototype:setQuest(quest)
	--sets the quest of the script
	self.quest = quest
end

function QuestScript.prototype:OnStart()
end
function QuestScript.prototype:OnUpdate()
end
function QuestScript.prototype:OnFinish()
end

function QuestScript.prototype:changeStage(stage)
	self.currentStage = stage
	OnStageChange(self.currentStage)
end

function QuestScript.prototype:OnStageChange(stage)
end
