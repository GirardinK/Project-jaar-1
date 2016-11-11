using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour {

    public Button Knop;
    public Text tekst;
    
	void Start () {
	
	}
    void Update() {

        if (Input.GetButton("Horizontal"))
        {
            //transform.position += Horizontal;
        }
    }
    public void Geklikt()
    {
        //Score = Score + 10;
        //tekst.text = ScoreManager.tostring();
                }

}
