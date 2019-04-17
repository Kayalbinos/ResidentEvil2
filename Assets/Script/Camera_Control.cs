using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    public float angularVelocity = 4.0f;
    //public GameObject Viseur;

    public GameObject player;

    private Camera cam;
    public float fov = 60;

    private void Start()
    {
        //Viseur.active = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = (vertical + angularVelocity * Input.GetAxis("Mouse Y")) % 360f;

        if (!(vertical < 25))
        {
            vertical = 25;
        }
        if(!(vertical > -20))
        {
            vertical = -20;
        }

        transform.eulerAngles = new Vector3(-vertical, player.GetComponent<Transform>().eulerAngles.y, transform.rotation.z);

        transform.position = player.GetComponent<Transform>().position;

        if (Input.GetButtonDown("Fire2"))
        {
            fov = 50;
            //Viseur.active = true;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            fov = 60;
            //Viseur.active = false;
        }

        if (fov == 50 && fov != cam.fieldOfView)
        {
            cam.fieldOfView -= 1;
        }
        else if (fov == 60 && fov != cam.fieldOfView)
        {
            cam.fieldOfView += 1;
        }
    }
}
