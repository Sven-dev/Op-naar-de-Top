using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kogel : MonoBehaviour {

    public Vector2 richting;
    public float snelheid;
    public float maxAfstand;
    public float huidigeAfstand;

	// Update is called once per frame
	void Update () {
        Vector3 afstand = richting * snelheid * Time.deltaTime;

        huidigeAfstand += afstand.x;

        transform.Translate(afstand);

        afstandBepalen();
	}

    //kijkt of de huidige afstand gelijk is aan de maximale afstand
    public void afstandBepalen()
    {
        if(huidigeAfstand > maxAfstand)
        {
            verwijderen();
        }
    }

    //verwijdert de kogel
    public void verwijderen()
    {
        Destroy(gameObject);
    }
}
