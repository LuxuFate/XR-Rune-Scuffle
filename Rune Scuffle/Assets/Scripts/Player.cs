using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    private int currentHP;
    [SerializeField] int maxHP;

    void Start() {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update() {
        
    }

    

}
