using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float MouseSensitivity { set; private get; }
    private float _rotX;
    private float _rotY;

    void Update()
    {
        _rotX += -Input.GetAxis("Mouse Y") * MouseSensitivity;
        _rotX = Mathf.Clamp(_rotX, -40, 40);
        _rotY += Input.GetAxis("Mouse X") * MouseSensitivity;
        transform.rotation = Quaternion.Euler(_rotX, _rotY, 0);
    }
}