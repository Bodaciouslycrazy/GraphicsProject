using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour {

	public Vector3 Rotation;

    // Use this for initialization
    void Start () {
		//nothing
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Rotation.x * 60 * Time.deltaTime, Rotation.y * 60 * Time.deltaTime, Rotation.z * 60 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
