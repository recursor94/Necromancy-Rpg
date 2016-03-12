--Vartable for script instance

scriptData = {

	varTable = {skeletonsKilled = 0},

	functTable =	{
			onUpdate = function()
				Debug.log("" .. varTable["skeletonsKilled"])
			end,
			onFinish = function()
			end,
			onStart = function()
			end,
		},

}
--tutorialQuestScript = Quest.new(quest,scriptData)
