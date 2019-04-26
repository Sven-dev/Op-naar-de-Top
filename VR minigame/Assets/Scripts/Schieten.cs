using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schieten : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();

        }
		
	}
    public GameObject kogel;
    //Kogels aanmaken
    public void shoot()
    {
        GameObject b = Instantiate(kogel);
        b.transform.position = transform.position;

    }

    /*
     * kogels bewegen
     * kogels verwijderen
     * kogel aanmaken
     * kogels on click
     * 
     */


}
