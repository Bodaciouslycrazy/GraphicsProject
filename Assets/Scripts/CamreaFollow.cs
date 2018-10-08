using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamreaFollow : MonoBehaviour {

	public Transform Following;

	public float PositionLerp = .5f;
	public float RotationLerp = .5f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, Following.position, PositionLerp);
		transform.rotation = Quaternion.Lerp(transform.rotation, Following.rotation, RotationLerp);
	}
}
