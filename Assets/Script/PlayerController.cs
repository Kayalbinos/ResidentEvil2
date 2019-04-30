using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Inventaire inventaire;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Animator Anim;

    public int Vie = 3;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    private float speedsave;
    private float horizontal;
    public float angularVelocity = 4.0f;

    void Start()
    {
        speedsave = speed;
        controller = GetComponent<CharacterController>();
        //inventaire = GameObject.Find("Inventory").GetComponent<Inventaire>();
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

        if (moveDirection.magnitude != 0)
        {
            Anim.SetBool("IsRunning", true);

        }
        else Anim.SetBool("IsRunning", false);

        

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
    /*private void OnTriggerStay(Collider collider)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (collider.tag == "Statuette")
            {
                if (collider.name == "Statuette1")
                {
                    inventaire.activation = true;
                    Statuette1 = 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Statuette2")
                {
                    inventaire.activation = true;
                    Statuette2 = 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Statuette3")
                {
                    inventaire.activation = true;
                    Statuette3 = 1;
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.tag == "Munition")
            {
                if (collider.name == "Munition_Pompe")
                {
                    inventaire.activation = true;
                    MunitionPompe += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Munition_Pistolet")
                {
                    inventaire.activation = true;
                    MunitionPistolet += 1;
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.tag == "Poudre")
            {
                if (collider.name == "Poudre_Jaune")
                {
                    inventaire.activation = true;
                    PoudreJ += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Poudre_Noir")
                {
                    inventaire.activation = true;
                    PoudreN += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Poudre_Blanche")
                {
                    inventaire.activation = true;
                    PoudreB += 1;
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.tag == "Plante")
            {
                if (collider.name == "Plante_Verte")
                {
                    inventaire.activation = true;
                    PlanteV += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Plante_rouge")
                {
                    inventaire.activation = true;
                    PlanteR += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Plante_Bleu")
                {
                    inventaire.activation = true;
                    PlanteB += 1;
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.tag == "Clée")
            {
                if (collider.name == "Pied_De_Biche")
                {
                    inventaire.activation = true;
                    PiedBiche += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Marteau")
                {
                    inventaire.activation = true;
                    Marteau += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Tournevis")
                {
                    inventaire.activation = true;
                    Tournevis += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Pince")
                {
                    inventaire.activation = true;
                    Pince += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Fusible")
                {
                    inventaire.activation = true;
                    Fusible += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Clée1")
                {
                    inventaire.activation = true;
                    clée1 += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Clée2")
                {
                    inventaire.activation = true;
                    clée2 += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Clée3")
                {
                    inventaire.activation = true;
                    clée3 += 1;
                    Destroy(collider.gameObject);
                }
                else if (collider.name == "Clée4")
                {
                    inventaire.activation = true;
                    clée4 += 1;
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.tag == "Sacoche")
            {
                inventaire.activation = true;
                Sacoche += 1;
                Destroy(collider.gameObject);
            }
            else if (collider.tag == "Arme")
            {
                if (collider.name == "Fusil_Pompe")
                {
                    inventaire.activation = true;
                    FusilPompe += 1;
                    Destroy(collider.gameObject);
                }
            }
        }
    }
    public int Statuette1;
    public int Statuette2;
    public int Statuette3;

    public int PlanteR;
    public int PlanteV;
    public int PlanteB;

    public int MunitionPompe;
    public int MunitionPistolet;

    public int PoudreJ;
    public int PoudreN;
    public int PoudreB;

    public int PiedBiche;
    public int Marteau;
    public int Tournevis;
    public int Pince;
    public int Fusible;

    public int clée1;
    public int clée2;
    public int clée3;
    public int clée4;

    public int FusilPompe;
    public int Pistolet;

    public int Sacoche;*/
}
