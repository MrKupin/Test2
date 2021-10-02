using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingShots : MonoBehaviour
{
    [SerializeField] private Text _score;
    private int _count;

    public void Counting()
    {
        _count++;
        _score.text = _count.ToString();
    }
}
