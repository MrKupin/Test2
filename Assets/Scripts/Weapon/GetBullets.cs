using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBullets : MonoBehaviour
{
    [SerializeField] private StorageBullets _storageBullets;
    [SerializeField] private CountBullets _countBullets;

    public GameObject GetBullet()
    {
        foreach (var bullet in _storageBullets.Bullets)
        {
            if (!bullet.gameObject.activeInHierarchy && bullet.IsWorking)
            {
                bullet.IsWorking = false;
                _countBullets.CountBullet();
                return bullet.gameObject;
            }
        }
        return null;
    }
}