using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {
    // Start is called before the first frame update

    protected int duration;
    protected int damage;

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    protected virtual void activateSpell() {
        //Generic Fizzle spell for when the program cant recognize the shape
    }


}
