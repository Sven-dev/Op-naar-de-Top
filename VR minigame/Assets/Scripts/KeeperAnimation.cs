using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperAnimation : MonoBehaviour {

    public List<Transform> Points;
    public Transform Origin;
    public float Speed;
    private bool Walking;

    private Animator anim;
    // Use this for initialization
	void Start () {
        StartCoroutine(Timer());
        anim = transform.GetChild(0).GetComponent<Animator>();

        Walking = false;
    }

    //Calls PickRandomSpot() every so often
    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (!Walking)
            {
                PickRandomSpot();
            }
        }
    }

    //Random direction and random chance to walk
    public void PickRandomSpot()
    {
        int walkChance = Random.Range(1, 100);
        if (walkChance > 75)
        {
            int index = Random.Range(0, Points.Count);
            StartCoroutine(Walk(Points[index]));
        }
    }

    //Walk to a direction and back
    IEnumerator Walk(Transform point)
    {
        Walking = true;
        anim.SetBool("isWalking", true);
        float delta = 0;

        //Walk to x position of point
        while(delta < 1)
        {
            transform.position = Vector3.Lerp(Origin.position, point.position, delta);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        delta = 0;

        //Wait
        yield return new WaitForSeconds(1f);

        //Walk back to origin
        while (delta < 1)
        {
            transform.position = Vector3.Lerp(point.position, Origin.position, delta);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        anim.SetBool("isWalking", false);
        Walking = false;
    }
}