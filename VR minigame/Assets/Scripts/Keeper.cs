using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject, 0.5f);
            Debug.Log("Collission Detected!");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
