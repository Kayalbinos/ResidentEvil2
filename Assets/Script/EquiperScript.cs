using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquiperScript : MonoBehaviour
{
    public int Slot;

    public GameObject Combiner;
    public GameObject Examiner;
    public GameObject Jeter;
    public GameObject Utiliser;
    public GameObject Equiper;

    public PlayerShoot Shoot;

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
            case 1:
                Shoot.Arme = 2;
                InventaireScript.item[Slot] = 2;
                Cancel();
                break;
            case 2:
                Shoot.Arme = 1;
                InventaireScript.item[Slot] = 1;
                Cancel();
                break;
            case 3:
                if (Shoot.ArmeSecondaire == 2)
                {
                    Shoot.ArmeSecondaire = 1;
                    InventaireScript.item[Slot] = 17;
                    Cancel();
                }
                else
                {
                    Shoot.ArmeSecondaire = 1;
                    InventaireScript.item[Slot] = 0;
                    Cancel();
                }
                break;
            case 17:
                if (Shoot.ArmeSecondaire == 1)
                {
                    Shoot.ArmeSecondaire = 2;
                    InventaireScript.item[Slot] = 3;
                    Cancel();
                }
                else
                {
                    Shoot.ArmeSecondaire = 2;
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
