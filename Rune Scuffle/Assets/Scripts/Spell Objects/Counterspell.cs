using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counterspell : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        Vector3 counterPos = transform.position;
        Collider[] colliders = Physics.OverlapBox(counterPos, new Vector3(1.5F, 1.5F, 1.5F));
        foreach (Collider hit in colliders) {
            if (collision.gameObject.CompareTag("Spell")) {
                Destroy(hit);
            }
        }
        print(collision.gameObject);
        if (collision.gameObject.CompareTag("Spell")) {
            Destroy(collision.gameObject);
        }
        Destroy(transform.root.gameObject, 0.25F);
    }
}
