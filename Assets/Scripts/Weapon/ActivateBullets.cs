using System.Collections.Generic;
using UnityEngine;

public class ActivateBullets : MonoBehaviour
{
    [SerializeField] private StorageBullets _storageBullets;
    [SerializeField] private CountBullets _countBullets;
    private List<Bullet> _bullets;
    private int _getNumberOfBullets;

    private void Start()
    {
        _bullets = _storageBullets.Bullets;
    }

    public void ActivateBullet(int number)
    {
        number = CheckNumber(number);
        int index;
        index = (_bullets.Count - 1) - _getNumberOfBullets - number;
        for (int i = _bullets.Count - 1; i > index; i--)
        {
            _bullets[i].IsWorking = true;
        }
        _countBullets.CountBullet();
    }

    private int CheckNumber(int number)
    {
        _getNumberOfBullets = _storageBullets.GetNumberOfBullets;
        var count = number + _getNumberOfBullets - _bullets.Count;
        if (count > 0)
        {
            number -= count;
            return number;
        }
        return number;
    }
}