using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeagueData : DataObject
{
	public string ShortName { get; set; }

	public TeamData[] Teams { get; set; }



	public override void OnCreated()
	{
		base.OnCreated();

		Teams = new TeamData[DataConstants.STD_LEAGUESIZE];
	}
}