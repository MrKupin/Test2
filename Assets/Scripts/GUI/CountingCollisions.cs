using UnityEngine;
using UnityEngine.UI;

public class CountingCollisions : MonoBehaviour
{
    [SerializeField] private Text _score;
    private int _count;

    public void Counting()
    {
        _count++;
        _score.text = _count.ToString();
    }
}