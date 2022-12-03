using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {
    private int currentHP;
    [SerializeField] int maxHP;

    // [SerializeField] bool isDummy;
    void Start() {
        currentHP = maxHP;
    }

    void Update() {
        
    }

    public void takeDamage(int damage)
    {
        Debug.Log("Taking " + damage + " Damage");
        currentHP = currentHP - damage;
        if (currentHP <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Debug.Log("Dummy Died");
        Destroy(this.gameObject);
    }
}
