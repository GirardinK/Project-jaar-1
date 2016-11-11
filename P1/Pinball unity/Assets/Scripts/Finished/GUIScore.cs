using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour
{


    public int huidigeScore;
    public int highScore;
    public int levens = 3;
    public bool bool1 = true;
    public bool bool2 = true;
    public bool bool3 = true;

    // vanaf de start heb je 3 levens

    public Texture2D plaatje1;

    void Start()
    {

    }

    void Update()
    {

        if (levens == 3)
        {

            bool1 = true;
            bool2 = true;
            bool3 = true;

        }

        if (levens == 2)
        {

            bool1 = true;
            bool2 = true;
            bool3 = false;

        }

        if (levens == 1)
        {

            bool1 = true;
            bool2 = false;
            bool3 = false;

        }

        if (levens < 1)

        {
            Application.LoadLevel("game over screen");
        }
        //als je minder dan 1 leven hebt (0 levens) dan laad hij een nieuwe scene, een game over screen
    }
    void OnGUI()
    {

        if (bool1 == true)
        {
            GUI.DrawTexture(new Rect(605, 160, 45, 45), plaatje1);
        }
        if (bool2 == true)
        {
            GUI.DrawTexture(new Rect(650, 160, 45, 45), plaatje1);
        }
        if (bool3 == true)
        {
            GUI.DrawTexture(new Rect(695, 160, 45, 45), plaatje1);
        }
        //de eerste 2 getallen geven de positie van mijn texture aan (plaatje) de laatste 2 de grootte)

    }

    public void Damage(int damage)
    {

        levens += damage;

    }
}