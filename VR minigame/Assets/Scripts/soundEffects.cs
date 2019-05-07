using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour {

    public AudioSource Bounce;

    public void PlayBounceSound ()
    {
        Bounce.Play();
    }

    void OnTriggerEnter()
    {
        Bounce.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            Debug.Log("Collission Detected!");
        }
    }
}
