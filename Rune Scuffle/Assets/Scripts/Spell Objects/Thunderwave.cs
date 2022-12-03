using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunderwave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if (!collision.gameObject.CompareTag("Ground")) {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, 5.0F);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(175.0F, explosionPos, 5.0F, 3.0F);

            }
            Destroy(transform.root.gameObject, 0.025F);
        }
    }
}
