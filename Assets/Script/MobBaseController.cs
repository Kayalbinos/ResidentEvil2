using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobBaseController : MonoBehaviour
{
    GameObject AttackObject;
    Inventaire Pause;

    public GameObject Player;

    public float movementSpeed;
    public NavMeshAgent agent;

    public int Vie = 10;
    private void Start()
    {
        Pause = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }
    void Update()
    {
        if (Pause.activation)
        {
            agent.isStopped = true;
        }
        else
        {
            agent.isStopped = false;
            agent.SetDestination(Player.transform.position);
            if (Vie <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
