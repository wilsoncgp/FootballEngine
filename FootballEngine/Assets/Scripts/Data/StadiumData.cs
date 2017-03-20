using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadiumData : DataObject
{
	// Could store ref to 3D Model?

	public int Capacity { get; set; }

	public override void OnCreated()
	{
		base.OnCreated();
	}
}