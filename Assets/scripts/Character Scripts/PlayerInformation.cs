using UnityEngine;
using System.Collections;

public class PlayerInformation : MonoBehaviour{


	public static int Level = 1;
	public static int HealthCap = 100;
	public static Actor.Gender Gender = Actor.Gender.MALE; //good enough default value
	public static string CharacterName = "Bob Smith";

	public static Actor PlayerActor = new PlayerActor();

	void Start() {
		
	}

	void Update () {
		
	}

}
