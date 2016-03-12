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
TutorialQuestScript = {}
function TutorialQuestScript:construct(quest)
	TutorialQuestScript = QuestScript.construct({quest})
	TutorialQuestScript.mt = {}
	TutorialQuestScript.mt.__index = QuestScript
end
TutorialQuestScript.skeletonsKilled = 0
function TutorialQuestScript:onUpdate()
	Debug.Log("Skeletons Killed: " .. self.skeletonsKilled)
end
