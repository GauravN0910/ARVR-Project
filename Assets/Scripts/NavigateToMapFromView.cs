using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class NavigateToMapFromView : MonoBehaviour
{
    public KeyCode interactKey;
    public KeyCode interactKey2;

    public UnityEvent interactAction1;
    public UnityEvent interactAction2;
    private void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            interactAction1.Invoke();
        }
        if (Input.GetKeyDown(interactKey2))
        {
            interactAction2.Invoke();
        }
    }
}
