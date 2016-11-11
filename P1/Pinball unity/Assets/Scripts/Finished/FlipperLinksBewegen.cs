using UnityEngine;
using System.Collections;

public class FlipperLinksBewegen : MonoBehaviour
{

    public float amount = 500000f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * -amount * Time.deltaTime, ForceMode.Impulse);
        }
        else
        {
            GetComponent<Rigidbody>().AddTorque(transform.forward * amount * Time.deltaTime, ForceMode.Impulse);
        }
    }  //als je de linker shifttoets ingedrukt houdt, dan gaat de flipper een vooruit.
        // laat je het los, dan gaat hij weer terug naar de startpositie
}
