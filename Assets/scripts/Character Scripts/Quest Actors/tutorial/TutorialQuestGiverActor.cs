using UnityEngine;
using System.Collections;

/*
 * script to represent behavior of first tutorial quest giver "Ivan The Outcast"
 * for now just contains container for id 
 */
using System;


public class TutorialQuestGiverActor : Actor{

	public static string Id = Guid.NewGuid ().ToString ();
	public static string CharacterName = "Ivan The Outcast";
	public static int Level = 1;
	public static int healthCap = 10;

	public TutorialQuestGiverActor() : base(null, CharacterName, Level, healthCap, Actor.Gender.MALE, Id){
		
	}

}
