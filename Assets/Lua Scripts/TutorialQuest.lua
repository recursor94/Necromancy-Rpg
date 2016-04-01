----Vartable for script instance
--
--scriptData = {
--
--	varTable = {skeletonsKilled = 0},
--
--	functTable =	{
--			onUpdate = function()
--				Debug.log("" .. varTable["skeletonsKilled"])
--			end,
--			onFinish = function()
--			end,
--			onStart = function()
--			end,
--		},
--
--}
----tutorialQuestScript = Quest.new(quest,scriptData)
TutorialQuestScript = QuestScript:makeScript({}, nil)
TutorialQuestScript.skeletonsKilled = 0


function TutorialQuestScript:onUpdate()
	Debug.Log("Skeletons Killed: " .. self.skeletonsKilled)
	QuestScript.onUpdate(self)
end
