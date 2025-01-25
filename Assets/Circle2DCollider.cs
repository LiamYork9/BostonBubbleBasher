using UnityEngine;

public class Circle2DCollider : MonoBehaviour
{
    public LayerMask enemyLayers;

    public float areaRange = 0.5f;

    public string baller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Area(); 
    }

    void Area()
    {
        Collider2D[] enemiesInArea = Physics2D.OverlapCircleAll(transform.position, areaRange, enemyLayers);

        foreach(Collider2D enemy in enemiesInArea)
        {
            Debug.Log(baller + enemy.name);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, areaRange);
    }
}
