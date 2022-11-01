using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpell : Spell {

    private float speed;
    [SerializeField] Fireball fireballPrefab;
    [SerializeField] GameObject player;

    void Start() {
        speed = 5f;
    }

    // Update is called once per frame
    void Update() {
        
    }

    protected override void activateSpell() {
        //Slow high damaging projectile
        Fireball fireball = Instantiate(fireballPrefab, player.transform.position, player.transform.rotation);
        //fireball.GetComponent<Rigidbody>().velocity = GET HAND DIRECTION * speed;
        
    }

}
