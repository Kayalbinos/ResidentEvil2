using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject InterfaceSlot;
    Inventaire InventaireScript;
    private void Start()
    {
        InterfaceSlot.active = false;
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }
    public void Selection()
    {
        InterfaceSlot.active = true;
        /*//Nr slot
        int nrSlot = transform.parent.GetSiblingIndex();
        //Decremente 1
        InventaireScript.slot[nrSlot] -= 1;*/
    }
}
