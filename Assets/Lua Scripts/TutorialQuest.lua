--Vartable for script instance

scriptData = {

	varTable = {skeletons = 0},

	functTable =	{
			onUpdate = function()
				Debug.log("" .. varTable["skeltonsKilled"])
			end,
			onFinish = function()
			end,
			onStart = function()
			end,
		},

}

