using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Interaction : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    private void Update()
    {
        if (inRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = true;
            UnityEngine.Debug.Log("Hi");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = false;
            UnityEngine.Debug.Log("Bye");
        }
    }
}
