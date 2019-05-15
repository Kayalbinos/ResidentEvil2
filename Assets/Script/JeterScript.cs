using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JeterScript : MonoBehaviour
{
    public int Slot;

    public GameObject Combiner;
    public GameObject Examiner;
    public GameObject Jeter;
    public GameObject Utiliser;
    public GameObject Equiper;

    Inventaire InventaireScript;

    void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }
    
    public void Selection()
    {
        InventaireScript.item[Slot] = 0;

        Combiner.SetActive(false);
        Examiner.SetActive(false);
        Utiliser.SetActive(false);
        Equiper.SetActive(false);
        Jeter.SetActive(false);
    }
}
