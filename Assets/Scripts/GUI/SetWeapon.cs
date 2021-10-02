using UnityEngine;

public class SetWeapon : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private StorageBullets _storageBullets;
    [SerializeField] private Shooting _shooting;
    [SerializeField] private ShowNumberOfBullets _showNumberOfBullets;

    public void Action()
    {
        _weapon.gameObject.SetActive(true);
        _storageBullets.CreateNewBullets(_weapon.NumberOfBullets);
        _shooting.Weapon = _weapon;
        _showNumberOfBullets.ShowNumber();
    }
}