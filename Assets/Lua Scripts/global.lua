import 'System'
import 'UnityEngine'
import 'Assembly-CSharp'

item = GameItem()
Debug.Log(LuaManager.Instance)
--require 'class' Doesn't work.
function test()
	Debug.Log("Test")
end

function teleport(movingtransform, destinationtransform) --Takes two transforms and moves the first param to the second param.
	movingtransform.position = destinationtransform.position --add conditional later to make this only work on the player
	--Debug.Log("Yes Andrew, the warp lua function did in fact work.")
end

--Define prototype for game scripts:
--GameScript = {}
--function GameScript:new(o)
--	local o = o or {} 
--	setmetatable(o, self)
--	self.__index = self
--	return o
--end
--function GameScript:onStart()
--	Debug.Log("Starting")
--end
--function GameScript:onUpdate()
--	Debug.Log("Updating")
--end
----End game script prototype
----
----Quest script prototype:
--Debug.Log(GameScript)
--
--QuestScript = GameScript:new({quest})
--Debug.Log(QuestScript)
--
--function QuestScript:new(quest)
--	self.quest = quest --argument passed must be C# Quest instance
--	self.currentStage = quest.Stage
--	return self
--end
--function QuestScript:update()
--	if self.currentStage == quest.Stage then
--		currentStage = quest.Stage
--		onStageChange(quest.Stage)
--	end
--end
--
--function QuestScript:onStageChange(stage)
--end
--
----Prototype for Game Script:
--GameScript = {}
--GameScript.__index = GameScript
----Constructor:
--function GameScript.new(scriptTable)
--	local instance = {
--	_scriptTable = scriptTable or {},
--	_onStartFunction = _scriptTable["functTable"]["onStart"] ,
--	_onUpdateFunction = _scriptTable["functTable"]["onUpdate"] ,
--	_onFinishFunction = _scriptTable["functTable"]["onFinish"] ,
--	_varTable = _scriptTable["varTable"] or nil
--	}
--	--set Gamescript as prototype for new instance:
--	setmetatable(instance, GameScript)
--	return instance
--end
--
----method definitions:
--function GameScript:onStart()
--	Debug.Log("Starting lua script")
--	_onStartFunction()
--end
--
--function GameScript:onUpdate()
--	Debug.Log("Lua script finished")
--	_onUpdateFunction()
--end
--
--function GameScript:onFinish()
--	Debug.Log("Lua script finished")
--	_onFinishFunction()
--end
--
--
----Quest Script class
--QuestScript = {}
----constructor
--QuestScript.__index = QuestScript
--
--function QuestScript.new(quest, scriptTable)
--	local instance = {
--		_quest = quest,
--		_currentStage = 0,
--		GameScript.new(self, scriptTable)
--	}
--
--	setmetatable(instance, QuestScript)
--	return instance
--end
----make GameScript prototype for QuestScript
--setmetatable(QuestScript, {__index = GameScript})
--
----instance methods
--function QuestScript:onStageChange(stage)
--	Debug.Log("Stage change detected, new stage is " .. stage)
--end
--function QuestScript:onUpdate()
--	if not self._currentStage == self.quest.Stage then
--		self._currentStage = quest.Stage
--		self.OnstageChange(self.quest.Stage)
--	end
--	GameScript.onUpdate(self)
--end
--
QuestScript = {}
QuestScript.prototype = {quest = {}, currentStage = 0}
QuestScript.mt = {}
function QuestScript.construct(object)
	setmetatable(object, QuestScript.mt)
	return object
end
QuestScript.mt.__index = function(table, key)
	return QuestScript.prototype[key]
end
function QuestScript:onStart()
end
function QuestScript:onUpdate()
	Debug.Log("Quest Stage: " .. self.quest.Stage)	
	if self.quest.Stage > self.currentStage then
		self.currentStage = self.quest.Stage
		onStageChange(self.quest.Stage)
	end
end
function QuestScript:onFinish()
end
function QuestScript:onStageChange(stage)
end
