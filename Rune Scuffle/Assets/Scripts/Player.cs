using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    private int currentHP;
    [SerializeField] int maxHP;

    [SerializeField] bool isDummy;

    void Start() {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update() {
        //Coroutine for recognizing spells
        //Activate spells for recognition
        //Fizzles if not
    }

    

}
