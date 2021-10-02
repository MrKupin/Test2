using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private static BulletCollision _instance;
    public static BulletCollision Instance => _instance;

    [SerializeField] private ActivateBullets _activateBullets;
    [SerializeField] private CountingShots _countingShots;
    [SerializeField] private ManagementTarget _spawnTarget;

    private void Awake()
    {
        _instance = this;
    }

    public void Collision()
    {
        _activateBullets.ActivateBullet(4);
        _countingShots.Counting();
        _spawnTarget.CountingPoints();
    }
}
