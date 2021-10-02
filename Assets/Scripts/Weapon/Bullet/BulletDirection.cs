using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    private Ray _ray;
    RaycastHit _hit;

    void Start()
    {
        
    }

    // Update is called once per frame
    public Vector3 Derection()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out _hit))
        {
            print(_hit.collider.gameObject.name);
            return _hit.point;
        }
        return Vector3.zero;
    }
}