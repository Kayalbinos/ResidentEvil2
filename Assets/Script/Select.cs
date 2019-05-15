using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public GameObject Combiner;
    public GameObject Examiner;
    public GameObject Jeter;
    public GameObject Utiliser;
    public GameObject Equiper;

    public int Slot;

    public GameObject Player;

    Inventaire InventaireScript;
    PlayerController PlayerScript;

    private void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
        PlayerScript = Player.GetComponent<PlayerController>();
    }
    public void Selection()
    {
        switch (InventaireScript.item[Slot])
        {
            case 0:
                if (PlayerScript.ItemAdd)
                {
                    AddObjet();
                    PlayerScript.ItemAdd = false;
                }
                break;
            case 1:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Equiper.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 2:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Equiper.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 3:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Equiper.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 4:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 4)
                {
                    InventaireScript.item[Slot] = 27;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 5)
                {
                    InventaireScript.item[Slot] = 28;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 4:
                            InventaireScript.item[Slot] = 27;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 5:
                            InventaireScript.item[Slot] = 28;
                            InventaireScript.item[InventaireScript.Slot]= 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Combiner.SetActive(true);
                    Utiliser.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 5:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 4)
                {
                    InventaireScript.item[Slot] = 28;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 6)
                {
                    InventaireScript.item[Slot] = 29;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 4:
                            InventaireScript.item[Slot] = 28;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 6:
                            InventaireScript.item[Slot] = 29;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Combiner.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }

                break;
            case 6:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 5)
                {
                    InventaireScript.item[Slot] = 29;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 6)
                {
                    InventaireScript.item[Slot] = 30;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 5:
                            InventaireScript.item[Slot] = 29;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 6:
                            InventaireScript.item[Slot] = 30;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Combiner.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 7:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 8:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    Examiner.SetActive(true);
                    Jeter.SetActive(true);
                    Combiner.SetActive(true);
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 9:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 10:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 11)
                {
                    InventaireScript.item[Slot] = 8;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 12)
                {
                    InventaireScript.item[Slot] = 8;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 11:
                            InventaireScript.item[Slot] = 8;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 12:
                            InventaireScript.item[Slot] = 8;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 11:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 10)
                {
                    InventaireScript.item[Slot] = 8;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 11)
                {
                    InventaireScript.item[Slot] = 9;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 12)
                {
                    InventaireScript.item[Slot] = 9;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 10:
                            InventaireScript.item[Slot] = 8;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 11:
                            InventaireScript.item[Slot] = 9;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 12:
                            InventaireScript.item[Slot] = 9;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 12:
                if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 10)
                {
                    InventaireScript.item[Slot] = 8;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 11)
                {
                    InventaireScript.item[Slot] = 9;
                    PlayerScript.ItemAdd = false;
                }
                else if (PlayerScript.ItemAdd && PlayerScript.ItemChoice == 12)
                {
                    InventaireScript.item[Slot] = 9;
                    PlayerScript.ItemAdd = false;
                }
                else if (InventaireScript.Combine && !InventaireScript.Security[Slot])
                {
                    switch (InventaireScript.item[InventaireScript.Slot])
                    {
                        case 10:
                            InventaireScript.item[Slot] = 8;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 11:
                            InventaireScript.item[Slot] = 9;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                        case 12:
                            InventaireScript.item[Slot] = 9;
                            InventaireScript.item[InventaireScript.Slot] = 0;
                            InventaireScript.Security[InventaireScript.Slot] = false;
                            InventaireScript.Combine = false;
                            break;
                    }
                }
                else if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 13:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 14:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 15:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 16:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 17:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 18:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 19:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 20:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 21:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 22:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 23:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 27:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 28:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 29:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
            case 30:
                if (!InventaireScript.Combine && !PlayerScript.ItemAdd)
                {
                    ItemUtilisable();
                }
                else
                {
                    CancelSelect();
                }
                break;
        }
    }
    public void ItemUtilisable()
    {
        Examiner.SetActive(true);
        Jeter.SetActive(true);
        Combiner.SetActive(true);
    }
    public void CancelSelect()
    {
        Utiliser.SetActive(false);
        Examiner.SetActive(false);
        Jeter.SetActive(false);
        Combiner.SetActive(false);
        Equiper.SetActive(false);
        InventaireScript.Security[InventaireScript.Slot] = false;
        InventaireScript.Combine = false;
        PlayerScript.ItemAdd = false;
    }
    public void AddObjet()
    {
        switch (PlayerScript.ItemChoice)
        {
            case 1:
                InventaireScript.item[Slot] = 1;
                break;

            case 2:
                InventaireScript.item[Slot] = 2;
                break;

            case 3:
                InventaireScript.item[Slot] = 3;
                break;

            case 4:
                InventaireScript.item[Slot] = 4;
                break;

            case 5:
                InventaireScript.item[Slot] = 5;
                break;

            case 6:
                InventaireScript.item[Slot] = 6;
                break;

            case 7:
                InventaireScript.item[Slot] = 7;
                break;

            case 8:
                InventaireScript.item[Slot] = 8;
                break;

            case 9:
                InventaireScript.MunitionPistolet += 6;
                InventaireScript.item[Slot] = 9;
                break;

            case 10:
                InventaireScript.item[Slot] = 10;
                break;

            case 11:
                InventaireScript.item[Slot] = 11;
                break;

            case 12:
                InventaireScript.item[Slot] = 12;
                break;

            case 13:
                InventaireScript.item[Slot] = 13;
                break;

            case 14:
                InventaireScript.item[Slot] = 14;
                break;

            case 15:
                InventaireScript.item[Slot] = 15;
                break;

            case 16:
                InventaireScript.item[Slot] = 16;
                break;

            case 17:
                InventaireScript.item[Slot] = 17;
                break;

            case 18:
                InventaireScript.item[Slot] = 18;
                break;

            case 19:
                InventaireScript.item[Slot] = 19;
                break;

            case 20:
                InventaireScript.item[Slot] = 20;
                break;

            case 21:
                InventaireScript.item[Slot] = 21;
                break;

            case 22:
                InventaireScript.item[Slot] = 22;
                break;

            case 23:
                InventaireScript.item[Slot] = 23;
                break;

            case 24:
                InventaireScript.item[Slot] = 24;
                break;

            case 25:
                InventaireScript.item[Slot] = 25;
                break;

            case 26:
                InventaireScript.item[Slot] = 26;
                break;
        }
    }
}
