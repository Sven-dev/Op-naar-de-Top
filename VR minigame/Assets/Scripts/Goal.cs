using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public Text ScoreText;
    public int Score;

    // Use this for initialization
    void Start() {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Score += 1;
            ScoreText.text = Score.ToString();
            Destroy(other.gameObject, 0.5f);
            Debug.Log("Collission Detected!");
            Bounce.Play();
        }
    }

    // Update is called once per frame
    void Update() {



    }

}

    public int Score;
    public AudioSource Bounce;

    // Use this for initialization
    void Start() {
