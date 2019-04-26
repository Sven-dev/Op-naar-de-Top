using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bewegen : MonoBehaviour {

    public bool IsHetSuperDuperLeuk;
    public string tekst;

    [Space]
    public int nummer;
    public int nummer2;
    public float decimaal;

    [Space]
    public Vector2 x;
    public Vector2 y;
    public float Speed; 

    [Space]
    public Transform kubus;

	// Use this for initialization
	void Start () {
        print(count(nummer, nummer2));
	}
	
	// Update is called once per frame
	void Update () {
        SuperDuperLeukCheck();

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            movement(x, Speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            movement(-x, Speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            movement(-y, Speed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            movement(y, Speed);
        }
    }

    public void SuperDuperLeukCheck()
    {
        if (IsHetSuperDuperLeuk == true)
        {
            print(tekst);
            IsHetSuperDuperLeuk = false;
        }
    }

    public void movement(Vector2 richting, float snelheid)
    {
        transform.Translate(richting * snelheid * Time.deltaTime);
    }

    public int count(int n1, int n2)
    {
        int result = n1 + n2;
        return result;
    }
}
