using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    private Ray _ray;
    RaycastHit _hit;

    public Vector3 Derection()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out _hit))
        {
            return _hit.point;
        }
        return Vector3.zero;
    }
}