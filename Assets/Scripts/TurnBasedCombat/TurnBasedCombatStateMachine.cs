using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMAchine : MonoBehaviour {

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN,
	}

	private BattleStates currentState;

	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
