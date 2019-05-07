using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public Text ScoreText;
    public int Score;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            Score = +1;
            ScoreText.text = Score.ToString();
            Destroy(other.gameObject, 0.5f);
        }
    }

	// Update is called once per frame
	void Update () {

        

    }
}
