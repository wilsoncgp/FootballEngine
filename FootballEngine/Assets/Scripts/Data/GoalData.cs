using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MatchPhase
{
	FirstHalf,
	SecondHalf,
	FirstHalfET,
	SecondHalfET,
	Penalties
}

public class GoalData : DataObject
{
	public PlayerData Goalscorer { get; set; }

	// TODO: Split into actual time scored
	public int MinuteScored { get; set; }

	// SHIT NAME
	public MatchPhase MatchPhase { get; set; }

	public bool OwnGoal { get; set; }

	public override void OnCreated()
	{
		base.OnCreated();
	}
}