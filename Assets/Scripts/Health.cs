using UnityEngine;

public class Health : MonoBehaviour
{

    public PlayerScript pScript;
    public int health = 5;

    public int expYeild = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        pScript.currentExp = pScript.currentExp += expYeild;
        pScript.killCount  += 1;

        Destroy(gameObject);
    }
}
