using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public Mover Ball;
    public Transform ARObject;

    private bool Waiting;

	// Update is called once per frame
	void Update ()
    {
		if (!Waiting && !BallCheck())
        {
            Waiting = true;
            StartCoroutine(BallTimeout());
        }
	}

    //Checks if there is a ball on screen
    private bool BallCheck()
    {
        if (transform.childCount == 0)
        {
            return false;
        }

        return true;
    }

    //Waits until a new ball needs to be spawned;
    IEnumerator BallTimeout()
    {
        yield return new WaitForSeconds(2f);
        SpawnBall();

        Waiting = false;

    }

    //spawn ball
    public void SpawnBall()
    {
        Mover BallClone = Instantiate(Ball, transform);
        BallClone.SetVariables(ARObject);
    }
}
