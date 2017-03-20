using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamData : DataObject
{
	public string ShortName { get; set; }

	public PlayerData[] Players { get; set; }

	public TeamsheetData[] Teamsheets { get; set; }

	public TeamsheetData ActiveTeamsheet
	{
		get
		{
			return Teamsheets[0];
		}
		set
		{
			var oldActiveTS = Teamsheets[0];
			for (int i = 0; i < Teamsheets.Length; i++)
			{
				if (Teamsheets[i].ObjectId == value.ObjectId)
				{
					Teamsheets[i] = oldActiveTS;
					break;
				}
			}
			Teamsheets[0] = value;
		}
	}

	public StadiumData Stadium { get; set; }

	public override void OnCreated()
	{
		base.OnCreated();

		Players = new PlayerData[DataConstants.MAX_SQUADSIZE];

		Teamsheets = new TeamsheetData[DataConstants.MAX_TEAMSHEETSIZE];
	}
}