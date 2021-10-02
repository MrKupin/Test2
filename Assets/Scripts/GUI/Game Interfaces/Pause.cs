using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : BaseGameInterface
{
    [SerializeField] private GameState disable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Action();
            disable.Disable();
        }
    }
}