using UnityEngine;
using System.Collections;

public class CombatAbility {

	private string name;
	private int baseDamage;
	private int doTDPS; //only for damage over time abilities, set to zero for instant


	public CombatAbility (string mName, int mBaseDamage) {
		this.name = mName;
		this.baseDamage = mBaseDamage;
		this.doTDPS = 0;
	}
	public CombatAbility (string mName, int mBaseDamage, int DotDPS) {
		this.name = mName;
		this.baseDamage = mBaseDamage;
		this.doTDPS = DotDPS;
	}


	public string Name {get{return name;}}
	public int BaseDamage{ get{return baseDamage;}}
}
