using UnityEngine;

public class CountBullets : MonoBehaviour
{
    [SerializeField] private StorageBullets _storageBullets;
    [SerializeField] private ShowNumberOfBullets _showNumberOfBullets;

    public void CountBullet()
    {
        var count = 0;
        foreach (var bullet in _storageBullets.Bullets)
        {
            if (bullet.IsWorking)
            {
                count++;
            }
        }
        _storageBullets.SetNumberOfBullets = count;
        _showNumberOfBullets.ShowNumber();
    }
}