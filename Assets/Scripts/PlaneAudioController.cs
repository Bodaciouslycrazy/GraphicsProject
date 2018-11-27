using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAudioController : MonoBehaviour {
    public Rigidbody rb;

    public AudioSource propAudio;
    public AudioSource windAudio;

    void Start()
    {
        //Stuff
    }

    void Update()
    {
        float velocity = rb.velocity.magnitude;

        //for wind type stuff
        windAudio.volume = Mathf.Clamp(velocity / 10f, 0.1f, 0.7f);
        windAudio.pitch = Mathf.Clamp(velocity / 20f + 0.8f, 0.8f, 1.1f);

        //for accel type stuff
        var targetPitch = (Input.GetButton("Fire1") ? 0.5f : 0f) + 0.7f;
        propAudio.pitch = propAudio.pitch + (targetPitch - propAudio.pitch) * Mathf.Clamp(Time.deltaTime * 1.2f, 0f, 1f);
    }
}
