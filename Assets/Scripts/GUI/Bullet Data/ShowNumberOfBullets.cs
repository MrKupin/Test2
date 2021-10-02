using UnityEngine;
using UnityEngine.UI;

public class ShowNumberOfBullets : MonoBehaviour
{
    [SerializeField] private Text _numberOfBullets;
    [SerializeField] private StorageBullets _storageBullet;

    void Start()
    {
        ShowNumber();
    }

    public void ShowNumber()
    {
        _numberOfBullets.text = _storageBullet.GetNumberOfBullets.ToString() + "/" + _storageBullet.Bullets.Count;
    }
}
