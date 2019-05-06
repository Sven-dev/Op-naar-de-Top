using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour {

    public bool Hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Hit)
        {
            Hit = false;
            Shoot();
        }
	}

    //Launches a ball
    private void Shoot()
    {

    }
}
