using UnityEngine;

public class Fireball : MonoBehaviour
{

    public void FireballDamage(GameObject enemy)
    {
        enemy.GetComponent<Health>()?.Hurt(gameObject.GetComponent<Attack>().damage/2);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
