using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

	public AudioSource audioSource;
    public double minimumVelocity;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
       
	}
	
	// Update is called once per frame
	void Update () {
        if(rb.velocity.magnitude >= minimumVelocity && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if(rb.velocity.magnitude < minimumVelocity && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        

	}
}
