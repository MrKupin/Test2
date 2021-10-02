using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private AudioSource _shotSound;
    [SerializeField] private Transform _muzzleOfWeapon;
    public abstract float RateOfFire { get; }
    public abstract int NumberOfBullets { get; }

    public bool Shot(GameObject bulletData, Vector3 target)
    {
        GameObject bullet = bulletData;
        if (bullet)
        {
            bullet.SetActive(true);
            bullet.transform.position = _muzzleOfWeapon.position;
            bullet.transform.rotation = Quaternion.LookRotation(target - bullet.transform.position);
            _shotSound.Play();
            return true;
        }
        return false;
    }
}