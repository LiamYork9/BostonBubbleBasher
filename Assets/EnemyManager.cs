using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    public GameObject waitinZone;
    public GameObject attackZone;
    public List<GameObject> waitQueue;
    public List<GameObject> attackQueue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        waitinZone = GameObject.FindWithTag("WaitArea");
        attackZone = GameObject.FindWithTag("EnemyAttackArea");
    }

    // Update is called once per frame
    void Update()
    {

        if(waitQueue.Count != waitinZone.GetComponent<Circle2DCollider>().enemyQueue.Count)
        {
            AddToQueue(waitQueue);
        }
        if (attackQueue.Count != attackZone.GetComponent<Circle2DCollider>().enemyQueue.Count)
        {
            AddToQueue(attackQueue);
        }

    }
    public void AddToQueue(List<GameObject> queue)
    {
        queue.Clear();
        for (int i = 0; i < waitinZone.GetComponent<Circle2DCollider>().enemyQueue.Count; i++)
        {
            queue.Add(waitinZone.GetComponent<Circle2DCollider>().enemyQueue[i].attachedRigidbody.gameObject);
        }
        for (int i = 0; i < queue.Count; i++)
        {
            queue[i].gameObject.GetComponent<enemyStateMachiene>().isWaiting = true;
        }
        queue[0].gameObject.GetComponent<enemyStateMachiene>().nextInQueue = true;
        queue.Add(queue[0].gameObject);
        queue.RemoveAt(0);
    }
}
