﻿using UnityEngine;
using System.Collections;
/*
 * represents all quest objectives and 
 * contains state for whether each objective is complete
 * can also update or change objective without completing it.
 * 
 */
public abstract class QuestObjective  {

	private bool isComplete;
	private string objectiveText;

}