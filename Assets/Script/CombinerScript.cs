using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinerScript : MonoBehaviour
{
    public int Slot;

    public GameObject Combiner;
    public GameObject Examiner;
    public GameObject Jeter;
    public GameObject Utiliser;
    public GameObject Equiper;

    public Sprite None;

    public Image image;

    Inventaire InventaireScript;

    void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }

    public void Selection()
    {
        InventaireScript.Slot = Slot;
        InventaireScript.Combine = true;
        InventaireScript.Security[Slot] = true;

        Combiner.SetActive(false);
        Examiner.SetActive(false);
        Utiliser.SetActive(false);
        Equiper.SetActive(false);
        Jeter.SetActive(false);
    }
}
