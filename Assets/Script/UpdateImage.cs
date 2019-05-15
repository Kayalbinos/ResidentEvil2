using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateImage : MonoBehaviour
{
    Image image;
    public Sprite None; //0

    public Sprite Pompe; //1
    public Sprite Pistolet; //2
    public Sprite Couteau; //3

    public Sprite PlanteV; //4
    public Sprite PlanteR; //5
    public Sprite PlanteB; //6

    public Sprite Spray; //7

    public Sprite MunitionPompe; //8
    public Sprite MunitionPistolet; //9
    public Sprite PoudreJaune; //10
    public Sprite PoudreNoire; //11
    public Sprite PoudreGrandeNoire; //12

    public Sprite PiedBiche; //13
    public Sprite Marteau; //14
    public Sprite Fusible; //15
    public Sprite Barricade; //16
    public Sprite Grenade; //17
    public Sprite Tournevis; //18
    public Sprite Pince; //19
    public Sprite Clée; //20

    public Sprite Statuette1; //21
    public Sprite Statuette2; //22
    public Sprite Statuette3; //23

    public Sprite Carte1; //24
    public Sprite Carte2; //25
    public Sprite Carte3; //26

    public Sprite PoudrePlanteVV; //27
    public Sprite PoudrePlanteVR; //28
    public Sprite PoudrePlanteBR; //29
    public Sprite PoudrePlanteBB; //30

    Inventaire InventaireScript;

    public int Slot;
    // Start is called before the first frame update
    void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
        image = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (InventaireScript.item[Slot])
        {
            case 0:
                image.sprite = None;
                break;
            case 1:
                image.sprite = Pompe;
                break;

            case 2:
                image.sprite = Pistolet;
                break;

            case 3:
                image.sprite = Couteau;
                break;

            case 4:
                image.sprite = PlanteV;
                break;

            case 5:
                image.sprite = PlanteR;
                break;

            case 6:
                image.sprite = PlanteB;
                break;

            case 7:
                image.sprite = Spray;
                break;

            case 8:
                image.sprite = MunitionPompe;
                break;

            case 9:
                image.sprite = MunitionPistolet;
                break;

            case 10:
                image.sprite = PoudreJaune;
                break;

            case 11:
                image.sprite = PoudreNoire;
                break;

            case 12:
                image.sprite = PoudreGrandeNoire;
                break;

            case 13:
                image.sprite = PiedBiche;
                break;

            case 14:
                image.sprite = Marteau;
                break;

            case 15:
                image.sprite = Fusible;
                break;

            case 16:
                image.sprite = Barricade;
                break;

            case 17:
                image.sprite = Grenade;
                break;

            case 18:
                image.sprite = Tournevis;
                break;

            case 19:
                image.sprite = Pince;
                break;

            case 20:
                image.sprite = Clée;
                break;

            case 21:
                image.sprite = Statuette1;
                break;

            case 22:
                image.sprite = Statuette2;
                break;

            case 23:
                image.sprite = Statuette3;
                break;

            case 24:
                image.sprite = Carte1;
                break;

            case 25:
                image.sprite = Carte2;
                break;

            case 26:
                image.sprite = Carte3;
                break;
        }
    }

}

