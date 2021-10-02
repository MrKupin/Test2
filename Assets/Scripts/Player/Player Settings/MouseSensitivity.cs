using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivity : MonoBehaviour
{
    [SerializeField] private Slider _sensitivityValue;
    [SerializeField] private PlayerRotation _mouseSensitivity;

    void Update()
    {
        _mouseSensitivity.MouseSensitivity = _sensitivityValue.value * 2;
    }
}
