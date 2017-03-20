using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonData : DataObject
{
	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string Pseudonym { get; set; }

	// Metres or Feet?
	public float Height { get; set; }

	// Kilos or Stone?
	public float Weight { get; set; }

	public DateTime DateOfBirth { get; set; }

	//Add nationality, place of birth
}