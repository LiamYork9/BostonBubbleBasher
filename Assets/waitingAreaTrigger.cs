using System;
using JetBrains.Annotations;
using UnityEngine;

public class waitingAreaTrigger : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            col.GetComponent<enemyStateMachiene>().isWaiting = true;
        }
    }
      void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            col.GetComponent<enemyStateMachiene>().isWaiting = false;
        }
    }
}

