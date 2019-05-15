using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtiliserScript : MonoBehaviour
{
    public int Slot;

    public GameObject Combiner;
    public GameObject Examiner;
    public GameObject Jeter;
    public GameObject Utiliser;
    public GameObject Equiper;

    public PlayerController Player;
    Inventaire InventaireScript;

    // Start is called before the first frame update
    void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }

    public void Selection()
    {
        switch (InventaireScript.item[Slot])
        {
            case 4:
                if (Player.Vie < 4)
                {
                    Player.Vie += 1;

                    InventaireScript.item[Slot] = 0;

                    Cancel();
                }
                break;
            case 13:
                if (Player.PiedBicheZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 14:
                if (Player.MarteauZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 15:
                if (Player.FusibleZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 18:
                if (Player.TournevisZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 19:
                if (Player.PinceZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 20:
                if (Player.CléeZone)
                {
                    Player.OpenZone = true;

                    Cancel();
                }
                break;
            case 27:
                if (Player.Vie < 4)
                {
                    Player.Vie += 2;

                    InventaireScript.item[Slot] = 0;

                    Cancel();
                }
                break;
            case 28:
                if (Player.Vie < 4)
                {
                    Player.Vie = 4;

                    InventaireScript.item[Slot] = 0;

                    Cancel();
                }
                break;
        }
    }
    public void Cancel()
    {
        Combiner.SetActive(false);
        Examiner.SetActive(false);
        Utiliser.SetActive(false);
        Equiper.SetActive(false);
        Jeter.SetActive(false);
    }
}
