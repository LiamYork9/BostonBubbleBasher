using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroySelf : MonoBehaviour
{
    
    public timer destroyTimer;
    public float duration = 10;

    private void Start()
    {
        destroyTimer = gameObject.AddComponent<timer>();
        if (destroyTimer.timeout == null)
            destroyTimer.timeout = new UnityEvent();

        destroyTimer.timeSet = duration;
        destroyTimer.timeout.AddListener(End);
    }

    void Update()
    {
        destroyTimer.StartTime();
    }
    public void End()
    {
        Destroy(gameObject);
    }
}
