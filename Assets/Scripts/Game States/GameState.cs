using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] private MonoBehaviour[] _objects;

    private void Start()
    {
        Disable();
    }

    public void Enable()
    {
        State(1, false, true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Disable()
    {
        State(0, true, false);
        Cursor.lockState = CursorLockMode.None;
    }

    private void State(int timeScale, bool visible, bool enabled)
    {
        Time.timeScale = timeScale;
        Cursor.visible = visible;
        foreach (var item in _objects)
        {
            item.enabled = enabled;
        }
    }
}
