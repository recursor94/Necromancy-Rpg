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
function GameScript:new()
	local o = {}
	setmetatable(o, self)
	self.__index = self
end
function GameScript:onStart()
end
function GameScript:onUpdate()
end
--End game script prototype
--
--Quest script prototype:
QuestScript = GameScript:new(quest)
