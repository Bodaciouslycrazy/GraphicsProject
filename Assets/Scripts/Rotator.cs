using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public Rigidbody rb;
	public float rollSpeed = 10f;
	public float rollAccel = 100f;
	public float pitchSpeed = 6f;
	public float pitchAccel = 100f;
	public float thrust = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		Vector3 targVect = new Vector3();

		targVect.z = -1 * Input.GetAxisRaw("Horizontal") * rollSpeed;
		targVect.x = Input.GetAxisRaw("Vertical") * pitchSpeed;

        Vector3 velDiff = targVect - transform.InverseTransformVector(rb.angularVelocity);

		Vector3 accel = Vector3.Scale(velDiff, new Vector3(1.0f, 0.01f, 1.0f)) / Time.fixedDeltaTime;

        if (accel.z > rollAccel)
            accel.z = rollAccel;
        else if (accel.z < -rollAccel)
            accel.z = -rollAccel;

		if (accel.x > pitchAccel)
			accel.x = pitchAccel;
		else if (accel.x < -pitchAccel)
			accel.x = -pitchAccel;

		rb.AddTorque(transform.TransformVector(accel * rb.mass));
		//rb.angularVelocity = transform.TransformVector(vel);

		//Needs to be removed
		float thr = Input.GetButton("Fire1") ? thrust : 0;
		rb.AddForce(transform.forward * thr);
	}
}
