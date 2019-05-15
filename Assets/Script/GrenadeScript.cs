using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScript : MonoBehaviour
{
    public float timer = 2;
    float countdown;
    public float radius = 0.1f;
    public float force = 500;

    bool hasexploded;

    //[SerializeField] GameObject exploParticule;
    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && !hasexploded)
        {
            Collider [] collider = Physics.OverlapSphere(transform.position, radius);
            foreach(Collider nearbyObject in collider)
            {
                if (nearbyObject.transform.tag == "Zombie")
                {
                    nearbyObject.GetComponent<MobBaseController>().Vie -= 30;
                }
            }
            hasexploded = true;
            Destroy(this.gameObject);
        }
    }
}
