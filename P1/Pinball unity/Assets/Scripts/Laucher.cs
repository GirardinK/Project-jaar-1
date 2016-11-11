using UnityEngine;
using System.Collections;

public class Laucher : MonoBehaviour {

    public float powerUp;
    public float powerUpMax = 1.5f;
    public bool pressed = false;

    public int maxforce = 1000;

    public Vector3 force = new Vector3 (0, 0, 10);
    public Rigidbody ball;
    public bool afgeschoten = false;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            
            pressed = true;
        } 
        if (Input.GetButtonUp("Jump") && afgeschoten == false)
        {
            pressed = false;

            afgeschoten = true;

            ball.AddForce(force * powerUp * maxforce);

            powerUp = 0;    
        }

        if (pressed)
        {
            powerUp += Time.deltaTime;

            if (powerUp > powerUpMax)
            {
                powerUp = powerUpMax;
                // Powerup kan niet hoger worden dan de waarde van powerupMax
            }
           
        }
    }

    public void OnTriggerEnter (Collider Player)
    {
        afgeschoten = false;
    }

}
