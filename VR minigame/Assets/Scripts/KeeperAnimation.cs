using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperAnimation : MonoBehaviour {

    public List<Transform> Points;
    public float Speed;
    private bool Walking;

    private Animator anim;
    // Use this for initialization
	void Start () {
        StartCoroutine(Timer());
        anim = transform.GetChild(0).GetComponent<Animator>();

        Walking = false;
        StartCoroutine(wait());
    }

    IEnumerator wait()   
    {
        yield return new WaitForSeconds(5);
        anim.SetBool("isWalking", true);     
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
        print(walkChance);
        if (walkChance > 75)
        {
            int index = Random.Range(0, Points.Count);
            StartCoroutine(Walk(Points[index].position));
        }
    }

    //Walk to a direction and back
    IEnumerator Walk(Vector3 point)
    {
        print("Walking");
        Walking = true;
        Vector3 origin = transform.position;
        float delta = 0;

        //Walk to x position of point
        while(delta < 1)
        {
            transform.position = new Vector3(Mathf.Lerp(origin.x, point.x, delta), transform.position.y, transform.position.z);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        delta = 0;

        //Wait
        yield return new WaitForSeconds(1f);

        //Walk back to origin
        while (delta < 1)
        {
            transform.position = new Vector3(Mathf.Lerp(point.x, origin.x, delta), transform.position.y, transform.position.z);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        Walking = false;
    }
}