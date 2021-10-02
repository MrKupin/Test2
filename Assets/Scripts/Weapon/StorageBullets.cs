using System.Collections.Generic;
using UnityEngine;

public class StorageBullets : MonoBehaviour
{
    [SerializeField] private List<Bullet> _bullets;
    public List<Bullet> Bullets => _bullets;
    [SerializeField] private Transform _parent;
    [SerializeField] public Bullet _bulletPrefab;
    public int SetNumberOfBullets { get; set; }
    public int GetNumberOfBullets => SetNumberOfBullets;

    public void CreateNewBullets(int number)
    {
        for (int i = 0; i < number; i++)
        {
            var bullet = Instantiate(_bulletPrefab, _parent);
            _bullets.Add(bullet);
        }
        SetNumberOfBullets = Bullets.Count;
    }
}