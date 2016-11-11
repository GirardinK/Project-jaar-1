using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int tellen = 0;
    public Text tekst;
    public int score;

    public void OnCollisionEnter(Collision collision)

    {
        Score.tellen = Score.tellen + 100;
        tekst.text = Score.tellen.ToString();

        // dit wilt zeggen dat elke keer je tegen iets aankomt waar je punten mee kan scoren dat er 100 wordt opgeteld in de UI

    }
}