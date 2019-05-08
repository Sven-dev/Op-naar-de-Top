using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperAnimation : MonoBehaviour
{
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
            if (!Walking && !anim.GetBool("isWaving"))
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
        if (walkChance > 66)
        {
            int index = Random.Range(0, Points.Count);

            if (index == 0)
            {
                StartCoroutine(Walk(Points[index], 1));
            }
            else if (index == 1)
            {
                StartCoroutine(Walk(Points[index], -1));
            }
            else
            {
                throw new System.Exception("Direction not specified");
            }        
        }
    }

    //Walk to a direction and back
    IEnumerator Walk(Transform point, int signum)
    {
        Walking = true;
        float delta = 0;

        //Rotate 90 degrees to position
        while (delta < 90)
        {
            transform.Rotate(Vector3.up * Speed * 200 * signum * Time.deltaTime);
            delta += Speed * 200 * Time.deltaTime;
            yield return null;
        }

        transform.localEulerAngles = Vector3.up * 90 * signum;
        anim.SetBool("isWalking", true);
        delta = 0;

        //Walk to x position of point
        while (delta < 1)
        {
            transform.position = Vector3.Lerp(Origin.position, point.position, delta);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        //Wait
        yield return new WaitForSeconds(0.25f);
        delta = 0;

        //Rotate 180 degrees back
        while (delta < 180)
        {
            transform.Rotate(Vector3.up * Speed * 300 * -signum * Time.deltaTime);
            delta += Speed * 300 * Time.deltaTime;
            yield return null;
        }

        transform.localEulerAngles = Vector3.up * 90 * -signum;
        delta = 0;

        //Walk back to origin
        while (delta < 1)
        {
            transform.position = Vector3.Lerp(point.position, Origin.position, delta);
            delta += Speed * Time.deltaTime;
            yield return null;
        }

        delta = 0;

        //Rotate 90 degrees to position
        while (delta < 90)
        {
            transform.Rotate(Vector3.up * Speed * 200 * signum * Time.deltaTime);
            delta += Speed * 200 * Time.deltaTime;
            yield return null;
        }

        transform.localEulerAngles = Vector3.zero;

        anim.SetBool("isWalking", false);
        Walking = false;
    }
}