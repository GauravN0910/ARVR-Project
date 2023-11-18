using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class NavigateToMapFromView : MonoBehaviour
{
    public KeyCode interactKey;
    public UnityEvent interactAction;
    private void Update() {
        if(Input.GetKeyDown(interactKey)){
            interactAction.Invoke();
        }
    }
}
