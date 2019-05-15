using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    MobBaseController Mob;
    public int Damage;
    public int DamagePerbullet;
    public int BulletNumber;
    public Camera cam;

    public int Arme;
    public int ArmeSecondaire;

    public float normalSpread = 0.04f;

    public Transform shootPoint;

    Inventaire InventaireScript;

    float countdown;

    [SerializeField]
    private LayerMask mask;
    
    void Start()
    {
        InventaireScript = GameObject.Find("Inventory").GetComponent<Inventaire>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Input.GetButton("Fire2") && InventaireScript.MunitionPistolet > 0)
        {
            if (Arme == 1)
            {
                ShootPistolet();
                InventaireScript.MunitionPistolet -= 1;
            }
            else if (Arme == 2)
            {
                ShootPompe();
                InventaireScript.MunitionPompe -= 1;
            }
        }
    }
    private void ShootPistolet()
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
    private void ShootPompe()
    {
        RaycastHit hit;
        Vector3 direction = cam.transform.forward; // Bullet Spread
        for (int a = 1; a<BulletNumber; a++)
        {
            direction.x += Random.Range(-normalSpread, normalSpread);
            direction.y += Random.Range(-normalSpread, normalSpread);
            direction.z += Random.Range(-normalSpread, normalSpread);
            if (Physics.Raycast(cam.transform.position, direction, out hit, 1000, mask))
            {
                if (hit.collider.tag == "Zombie")
                {
                    Mob.Vie -= DamagePerbullet;
                }
            }
        }
    }
}
