using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public Button exit;
    // Use this for initialization
    void Start()
    {

        exit = exit.GetComponent<Button>();

    }

    // Update is called once per frame
    public void Startgame()
    {
        SceneManager.LoadScene("PinballFinal");
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}
