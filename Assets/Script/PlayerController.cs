using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Inventaire inventaire;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    public int Vie = 4;

    public int FusilPompe;
    public int Pistolet;

    public int Sacoche;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    private float speedsave;
    private float horizontal;
    public float angularVelocity = 4.0f;

    public int ItemChoice = 4;

    public bool ItemAdd;

    public bool PiedBicheZone;
    public bool MarteauZone; 
    public bool FusibleZone; 
    public bool TournevisZone; 
    public bool PinceZone; 
    public bool CléeZone;

    public bool OpenZone;

    void Start()
    {
        speedsave = speed;
        controller = GetComponent<CharacterController>();
        inventaire = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = speedsave*2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speedsave;
        }


        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);


        controller.Move(moveDirection * Time.deltaTime);

        horizontal = (horizontal + angularVelocity * Input.GetAxis("Mouse X")) % 360f;
        transform.rotation = Quaternion.AngleAxis(horizontal, Vector3.up);

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Zombie")
        {
            Vie -= 1;
        }
    }
    private void OnTriggerStay(Collider collider)
    {
        if (!inventaire.activation)
        {
            if (collider.tag == "ZoneLock")
            {
                if (collider.name == "PiedbicheLock")
                {
                    PiedBicheZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        PiedBicheZone = false;
                    }
                }
                else if (collider.name == "MarteauLock")
                {
                    MarteauZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        MarteauZone = false;
                    }
                }
                else if (collider.name == "FusibleLock")
                {
                    FusibleZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        FusibleZone = false;
                    }
                }
                else if (collider.name == "TournevisLock")
                {
                    TournevisZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        TournevisZone = false;
                    }
                }
                else if (collider.name == "PinceLock")
                {
                    PinceZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        PinceZone = false;
                    }
                }
                else if (collider.name == "CléeLock")
                {
                    CléeZone = true;
                    if (OpenZone)
                    {
                        Destroy(collider.gameObject);
                        OpenZone = false;
                        CléeZone = false;
                    }
                }
            }

            else if (Input.GetButtonDown("Fire1") && !Input.GetButton("Fire2"))
            {
                if (collider.tag == "Statuette")
                {
                    if (collider.name == "Statuette1")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 21;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Statuette2")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 22;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Statuette3")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 23;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                }
                else if (collider.tag == "Munition")
                {
                    if (collider.name == "Munition_Pompe")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 8;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Munition_Pistolet")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 9;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                }
                else if (collider.tag == "Poudre")
                {
                    if (collider.name == "Poudre_Jaune")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 10;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Poudre_Noir")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 11;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Poudre_Grande_Noire")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 12;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                }
                else if (collider.tag == "Plante")
                {
                    if (collider.name == "Plante_Verte")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 4;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Plante_rouge")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 5;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Plante_Bleu")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 6;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                }
                else if (collider.tag == "Clée")
                {
                    if (collider.name == "Pied_De_Biche")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 13;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Marteau")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 14;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Tournevis")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 18;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Pince")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 19;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Fusible")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 15;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Clée1")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 20;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    /*else if (collider.name == "Clée2")
                    {
                        inventaire.AutoActivation = true;
                        clée2 += 1;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Clée3")
                    {
                        inventaire.AutoActivation = true;
                        clée3 += 1;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                    else if (collider.name == "Clée4")
                    {
                        inventaire.AutoActivation = true;
                        clée4 += 1;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }*/
                }
                /*else if (collider.tag == "Sacoche")
                {
                    inventaire.AutoActivation = true;
                    Sacoche += 1;
                    Destroy(collider.gameObject);
                    ItemAdd = true;
                }*/
                else if (collider.tag == "Arme")
                {
                    if (collider.name == "Fusil_Pompe")
                    {
                        inventaire.AutoActivation = true;
                        ItemChoice = 1;
                        Destroy(collider.gameObject);
                        ItemAdd = true;
                    }
                }
            }
        }
    }
}
