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

function QuestScript:makeScript(object)
	--make script child of quest script
	metaTable = {}
	setAsIndex(metaTable)
	setmetatable(object, metatable)
end
	
	

function QuestScript:OnStart()
end
function QuestScript:OnUpdate()
end
function QuestScript:OnFinish()
end

function QuestScript:changeStage(stage)
	self.currentStage = stage
	OnStageChange(self.currentStage)
end

function QuestScript:OnStageChange(stage)
end
