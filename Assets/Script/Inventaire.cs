using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventaire : MonoBehaviour
{
    public bool activation = false;
    public bool AutoActivation;
    public GameObject Player;
    public GameObject Camera;

    public int Slot;

    public bool Combine;
    
    public int[] item = new int[4];

    public bool[] Security = new bool[4];

    public int MunitionPistolet = 8;
    public int MunitionPompe;

    public Text NombreMunitions;

    public bool Desactive;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || AutoActivation)
        {
            AutoActivation = false;
            activation = !activation;
            GetComponent<Canvas>().enabled = activation;

            if (activation)
            {
                Player.GetComponent<PlayerController>().enabled = false;
                Camera.GetComponent<Camera_Control>().enabled = false;
                Player.GetComponent<PlayerShoot>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Player.GetComponent<PlayerController>().enabled = true;
                Camera.GetComponent<Camera_Control>().enabled = true;
                Player.GetComponent<PlayerShoot>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        NombreMunitions.text = MunitionPistolet.ToString();
    }
}
