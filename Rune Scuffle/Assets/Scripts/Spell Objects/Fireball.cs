using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField] private int damage = 20;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision){
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, 5.0F);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(100.0F, explosionPos, 5.0F, 3.0F);
            }

            if (hit.transform.CompareTag("Dummy"))
            {
                Dummy dummy = hit.transform.GetComponent<Dummy>();
                dummy.takeDamage(damage);
            }
        }
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
        Destroy(transform.root.gameObject);
        
        Destroy(expl, 2); // delete the explosion after 2 seconds
    }
}
