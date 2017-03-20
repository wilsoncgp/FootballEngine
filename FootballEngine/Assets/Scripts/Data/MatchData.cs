using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result
{
	HomeWin,
	AwayWin,
	Draw
}

public class MatchData : DataObject
{
	public string ShortName { get; set; }

	public TeamMatchData HomeTeam { get; set; }

	public TeamMatchData AwayTeam { get; set; }

	public RefereeData Referee { get; set; }

	public Result Result
	{
		get
		{
			if (HomeTeam.Goals > AwayTeam.Goals)
			{
				return Result.HomeWin;
			}

			if (AwayTeam.Goals > HomeTeam.Goals)
			{
				return Result.AwayWin;
			}

			return Result.Draw;
		}
	}

	public StadiumData Stadium
	{
		get
		{
			return !IsNeutralGround ? HomeTeam.Team.Stadium : null;
		}
	}

	// TODO: Split attendance into Home, Away and Neutral?
	public int Attendance { get; set; }

	public bool IsNeutralGround { get; set; }

	public DateTime Date { get; set; }

	//TODO: Add Stoppage time minutes?

	public override void OnCreated()
	{
		base.OnCreated();
	}

	public string ScoreString
	{
		get
		{
			return string.Format("{0}-{1}", HomeTeam.Goals, AwayTeam.Goals);
		}
	}
}

public class TeamMatchData
{
	public TeamData Team { get; set; }

	public int Goals
	{
		get
		{
			return Goalscorers.Length;
		}
	}

	public GoalData[] Goalscorers { get; set; }

	public float Possession { get; set; }

	public int Shots { get; set; }

	public int ShotsOnTarget { get; set; }

	public int Corners { get; set; }

	public int Fouls { get; set; }
}