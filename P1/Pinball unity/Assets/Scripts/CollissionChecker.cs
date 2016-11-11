using UnityEngine;
using System.Collections;

public class CollissionChecker : MonoBehaviour {
    
    public GameObject master;
    public Transform spawnPoint;
    public Laucher blok;
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
            GUIScore gc = (GUIScore)master.GetComponent("GUIScore");
            gc.Damage(-1);
            other.gameObject.transform.position = spawnPoint.position;

            blok.afgeschoten = false;


        }

      }

}