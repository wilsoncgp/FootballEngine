using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamsheetData : DataObject
{
	public PlayerTeamsheetData[] Players { get; set; }

	public SetPieceIDs SetPieceIDs { get; set; }

	public int CaptainID { get; set; }
	
	public override void OnCreated()
	{
		base.OnCreated();

		Players = new PlayerTeamsheetData[DataConstants.TEAMSHEET_STD_SQUADSIZE];
	}
}

public class PlayerTeamsheetData
{
	public Guid PlayerID { get; set; }

	public Position? Position { get; set; }

	public Vector2? PitchCoordinates { get; set; }

	public bool FirstTeam { get; set; }
}

public class SetPieceIDs
{
	public int ShortFreeKicks { get; set; }
	public int LongFreeKicks { get; set; }
	public int LeftCorners { get; set; }
	public int RightCorners { get; set; }
	public int Penalties { get; set; }
}