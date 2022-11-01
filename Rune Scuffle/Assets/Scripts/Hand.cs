using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Hand : MonoBehaviour {
    [SerializeField] public InputActionReference controllerActionTrigger;
    private XRDirectInteractor interactor;
    private float prevTrigger = 0f;
    // [SerializeField] 

    private void Start() {
        interactor = GetComponent<XRDirectInteractor>();
    }

    // Update is called once per frame
    void Update() {
        float trigger = controllerActionTrigger.action.ReadValue<float>();
        if (trigger != 0) {
            Debug.Log("SS");
        }
        // prevTrigger = trigger;
    }
}
