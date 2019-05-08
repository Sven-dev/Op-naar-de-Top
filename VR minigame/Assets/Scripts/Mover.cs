using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform ARObject;
    private Rigidbody rb;

	// Use this for initialization
	void Start()
    {
        rb = GetComponent<Rigidbody>();
	}

    private void OnMouseDown()
    {
        transform.parent = ARObject;
        rb.AddForce(Vector3.forward * 150);
        rb.useGravity = true;
        tag = "Ball";
    }

    //Sets the variables when the object is spawned
    public void SetVariables(Transform arobject)
    {
        ARObject = arobject;
    }
}