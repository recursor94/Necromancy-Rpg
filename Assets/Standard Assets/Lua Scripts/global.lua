import 'System'
import 'UnityEngine'
import 'Assembly-CSharp'

--require 'class' Doesn't work.
function test()
	Debug.Log("Test")
end

function teleport(movingtransform, destinationtransform) --Takes two transforms and moves the first param to the second param.
	movingtransform.position = destinationtransform.position --add conditional later to make this only work on the player
	--Debug.Log("Yes Andrew, the warp lua function did in fact work.")
end

--Define prototype for game scripts:
GameScript = {}
function GameScript:new(o)
	local o = o or {} 
	setmetatable(o, self)
	self.__index = self
	return o
end
function GameScript:onStart()
end
function GameScript:onUpdate()
end
--End game script prototype
--
--Quest script prototype:
Debug.Log(GameScript)

QuestScript = GameScript:new({quest})
Debug.Log(QuestScript)

function QuestScript:new(quest)
	self.quest = quest --argument passed must be C# Quest instance
	self.currentStage = quest.Stage
	return self
end
function QuestScript:update()
	if self.currentStage == quest.Stage then
		currentStage = quest.Stage
		onStageChange(quest.Stage)
	end
end

function QuestScript:onStageChange(stage)
end
