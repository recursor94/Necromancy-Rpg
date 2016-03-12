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
TutorialQuest = QuestScript.Construct({})
TutorialQuest.skeletonsKilled = 0
function TutorialQuest:onUpdate()
	Debug.Log("Skeletons Killed: " .. self.skeletonsKilled)
end
