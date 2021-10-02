using UnityEngine;

public abstract class BaseGameInterface : MonoBehaviour
{
    [SerializeField] protected StorageInterfaces _storageInterfaces;
    [SerializeField] private BaseGameInterface _startInterface;

    public virtual void Action()
    {
        _storageInterfaces.StartInterface(_startInterface);
    }
}