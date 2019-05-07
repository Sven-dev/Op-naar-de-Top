using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform StableObject;
    public Transform ARObject;
    public bool Tapped;
    private Rigidbody rb; 

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
	}
	

    void OnMouseDown()
    {
        Tapped = true;
        transform.parent = ARObject;

        rb.AddForce(Vector3.forward * 35);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            print("Goal!");
            
        }
    }
}