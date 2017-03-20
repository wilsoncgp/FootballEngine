using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataObject
{
	public Guid ObjectId { get; private set; }

	public string Name { get; set; }

	public virtual void OnCreated() { ObjectId = Guid.NewGuid(); }

	public virtual void OnValidate() { }
}
