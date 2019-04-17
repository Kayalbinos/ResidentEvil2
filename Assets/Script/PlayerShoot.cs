using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    MobBaseController Mob;
    public int Damage;
    public Camera cam;

    [SerializeField]
    private LayerMask mask;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Input.GetButton("Fire2"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 1000, mask))
        {
            if (hit.collider.tag == "Zombie")
            {
                Mob = hit.collider.gameObject.GetComponent<MobBaseController>();
                Mob.Vie -= Damage;
            }
        }
    }
}
