using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Circle2DCollider : MonoBehaviour
{
    public LayerMask enemyLayers;

    public float areaRange = 0.5f;
    public List<Collider2D> enemyQueue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyQueue.Clear();
       Area(); 
    }

    void Area()
    {
        Collider2D[] enemiesInArea = Physics2D.OverlapCircleAll(transform.position, areaRange, enemyLayers);

        for(int i = 0; i < enemiesInArea.Length; i++)
        {
            enemyQueue = enemiesInArea.ToList();
        }

        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, areaRange);
    }
}
