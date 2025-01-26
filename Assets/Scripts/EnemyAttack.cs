using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage=2;
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
            if(other.GetComponent<PlayerScript>()!=null)
            {
                other.GetComponent<PlayerScript>().currentHP-=(damage-other.GetComponent<PlayerScript>().defense);
            }
            //hitTarget.Invoke(other.gameObject);
        }
    }
}
