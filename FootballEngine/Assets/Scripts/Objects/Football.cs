using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour {

	public Vector3 velocity;
	public Vector3 angularVelocity;
	public float magnusConstant;

	private Rigidbody rBody;

	// Use this for initialization
	void Start () {
		rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rBody.velocity = velocity;
			rBody.angularVelocity = angularVelocity;
		}

		Vector3 magnusForce = magnusConstant * Time.deltaTime * Vector3.Cross(rBody.angularVelocity, rBody.velocity);
		rBody.AddForce(magnusForce);
	}
}
