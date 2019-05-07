using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Stabilizes the AR-object
public class Stabilizer : MonoBehaviour
{
    public bool Position;
    public bool Rotation;
    [Space]
    public int Decimals;

	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Position)
        {
            double x = Math.Round(transform.position.x, Decimals);
            double y = Math.Round(transform.position.y, Decimals);
            double z = Math.Round(transform.position.z, Decimals);
            transform.position = new Vector3((float)x, (float)y, (float)z);
        }

        if (Rotation)
        {
            float x = (float)Math.Round(transform.rotation.x, Decimals);
            float y = (float)Math.Round(transform.rotation.y, Decimals);
            float z = (float)Math.Round(transform.rotation.z, Decimals);

            transform.eulerAngles = new Vector3(x, y, z);

        }
	}
}
