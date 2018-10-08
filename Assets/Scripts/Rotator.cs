using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public Rigidbody rb;
	public float rollSpeed = 10f;
	public float pitchSpeed = 6f;
	public float thrust = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		Vector3 vel = new Vector3();

		vel.z = -1 * Input.GetAxisRaw("Horizontal") * rollSpeed;
		vel.x = Input.GetAxisRaw("Vertical") * pitchSpeed;


		rb.angularVelocity = transform.TransformVector(vel);

		float thr = Input.GetButton("Fire1") ? thrust : 0;
		rb.AddForce(transform.forward * thr);

	}
}
