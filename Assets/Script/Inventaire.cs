using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventaire : MonoBehaviour
{
    public bool activation = false;
    public GameObject Player;
    public GameObject Camera;
    GameObject P;
    public int[] slot;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        P = transform.GetChild(0).gameObject;
        slot = new int[P.transform.childCount];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
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
                Player.GetComponent<PlayerShoot>().enabled = false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
