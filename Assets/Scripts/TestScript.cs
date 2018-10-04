using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	public Vector3 Rotation;
	public float Speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Rotation * Time.deltaTime * Speed, Space.Self);

	}
}
