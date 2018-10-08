using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour {

	public float SurfaceArea = 5f;
	public float AerodynamicConstant = .25f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		Vector3 vel = rb.velocity;
		Vector3 norm = transform.up;

		vel = Vector3.Project(vel, norm);

		vel = vel * -1;

		vel = vel * SurfaceArea * AerodynamicConstant;

		vel = vel * vel.magnitude;

		rb.AddForce(vel);
	}
}
