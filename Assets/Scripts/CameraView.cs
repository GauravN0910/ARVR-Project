using System.Reflection;
using System;
using System.Numerics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraView : MonoBehaviour
{
    public float mouseSensitivity = 300f;
    public Transform playerBody;

    float xRotation = 0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = UnityEngine.Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(UnityEngine.Vector3.up * mouseX);
    }
}
