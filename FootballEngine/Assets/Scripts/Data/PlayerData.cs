using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public enum Position
{
	Goalkeeper,
	Sweeper,
	CentreBack,
	RightBack,
	LeftBack,
	DefensiveMidfielder,
	CentreMidfielder,
	RightMidfielder,
	LeftMidfielder,
	AttackingMidfielder,
	RightWinger,
	LeftWinger,
	CentreForward,
	Striker,
	MAX
}

public class PlayerData : PersonData
{
	public string ShirtName { get; set; }

	public int? SquadNumber { get; set; }

	public int? NationalSquadNumber { get; set; }

	public Position?[] Positions { get; set; }

	public Position? PreferredPosition
	{
		get
		{
			return Positions[0];
		}
		set
		{
			Position? oldFave = Positions[0];
			for(int i = 0; i < Positions.Length; i++)
			{
				if (!Positions[i].HasValue) break;

				if (Positions[i] == value)
				{
					Positions[i] = oldFave;
					break;
				}
			}
			Positions[0] = value;
		}
	}

	public override void OnCreated()
	{
		base.OnCreated();

		Positions = new Position?[(int)Position.MAX];
	}

	public override void OnValidate()
	{
		if (SquadNumber.HasValue)
		{
			SquadNumber = Mathf.Clamp(SquadNumber.Value, 1, 99);
		}

		if (NationalSquadNumber.HasValue)
		{
			NationalSquadNumber = Mathf.Clamp(NationalSquadNumber.Value, 1, 99);
		}
	}
}