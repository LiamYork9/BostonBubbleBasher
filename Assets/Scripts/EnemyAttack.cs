using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage=1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Enemy");
            other.GetComponent<PlayerScript>()?.currentHP;
            //hitTarget.Invoke(other.gameObject);
        }
    }
}
