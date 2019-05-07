using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform StableObject;
    public Transform ARObject;
    public bool Tapped;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Tapped)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
	}

    void OnMouseDown()
    {
        Tapped = true;
        transform.parent = ARObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            print("Goal!");
            
        }
    }
}