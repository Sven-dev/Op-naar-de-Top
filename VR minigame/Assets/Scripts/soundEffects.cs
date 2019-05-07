using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour {

    public AudioSource Bounce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Soccer Ball")
        {
            Debug.Log("Collission Detected!");
            Bounce.Play();
        }
    }
}
