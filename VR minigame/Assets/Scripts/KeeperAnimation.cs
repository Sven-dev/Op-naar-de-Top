using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperAnimation : MonoBehaviour {

    Animator anim;
    // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        StartCoroutine(wait());
    }

    IEnumerator wait()   
    {
        yield return new WaitForSeconds(5);
        anim.SetBool("isWalking", true);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
