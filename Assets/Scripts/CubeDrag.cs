using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrag : MonoBehaviour {

	public Vector3 CubeSurfaceArea;
	public float AerodynamicConstant = .25f;

	public Rigidbody rb;

	private void FixedUpdate()
	{
		Vector3 vel = rb.velocity;
		//Vector3 norm = transform.up;

		//vel = Vector3.Project(vel, norm);

		Vector3 force =
			GetAxisDrag(Vector3.Project(vel, transform.up), CubeSurfaceArea.y) +
			GetAxisDrag(Vector3.Project(vel, transform.right), CubeSurfaceArea.x) +
			GetAxisDrag(Vector3.Project(vel, transform.forward), CubeSurfaceArea.z);

		rb.AddForce(force);
	}

	private Vector3 GetAxisDrag( Vector3 velocity, float surfaceArea)
	{
		velocity = -1 * velocity * surfaceArea * AerodynamicConstant;
		velocity = velocity * velocity.magnitude;
		return velocity;
	}
}
