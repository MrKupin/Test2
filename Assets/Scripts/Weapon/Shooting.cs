using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Weapon Weapon { get; set; }
    [SerializeField] private GetBullets _getBullets;
    [SerializeField] private BulletDirection bulletDirection;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _weaponPosition;
    private bool _isReady = true;

    private void Update()
    {
        Weapon.transform.position = _weaponPosition.position;
        Weapon.transform.rotation = _weaponPosition.rotation;
        Shoot();
    }

    public void Shoot()
    {
        bool checkBullet;
        if (Input.GetMouseButton(0) && _isReady == true)
        {
            checkBullet  = Weapon.Shot(_getBullets.GetBullet(), bulletDirection.Derection());
            if (checkBullet == true)
                _animator.SetTrigger("Push");
            _isReady = false;
            StartCoroutine(Recharge());
        }
    }

    IEnumerator Recharge()
    {
        yield return new WaitForSeconds(Weapon.RateOfFire);
        _isReady = true;
    }
}