using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : BaseGameInterface
{
    [SerializeField] private GameState enable;

    public override void Action()
    {
        base.Action();
        enable.Enable();
    }
}