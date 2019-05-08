using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text ScoreText;
    public int Score;
    public AudioSource Bounce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Score += 1;
            ScoreText.text = Score.ToString();
            Destroy(other.gameObject, 0.5f);
            Bounce.Play();
        }
    }
}