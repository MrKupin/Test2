using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageInterfaces : MonoBehaviour
{
    [SerializeField] private BaseGameInterface[] _interfaces;

    public void StartInterface(BaseGameInterface @interface)
    {
        bool active;
        foreach (var item in _interfaces)
        {
            if (item.GetType() == @interface.GetType())
            {
                active = true;
            }
            else
            {
                active = false;
            }
            item.gameObject.SetActive(active);
        }
    }
}