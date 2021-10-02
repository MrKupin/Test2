using UnityEngine;

public class ManagementTarget : MonoBehaviour
{
    [SerializeField] private GameObject[] _targets;

    private void Start()
    {
        Activity();
    }

    public void CountingPoints()
    {
        int count = -1;
        for (int i = 0; i < _targets.Length; i++)
        {
            if (_targets[i].activeInHierarchy)
            {
                count++;
                print(count);
            }
        }
        if (count == 0)
        {
            Activity();
        }
    }

    private void Activity()
    {
        var count = Random.Range(2, 6);
        for (int i = 0; i < count; i++)
        {
            _targets[i].SetActive(true);
        }
    }
}