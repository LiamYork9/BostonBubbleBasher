using UnityEngine;

public class ReactiveShield : MonoBehaviour
{
    public int damage = 5;

    public void ReactiveShieldEffect()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                Debug.Log("Enemy");
                other.GetComponent<Health>()?.Hurt(damage);
                gameObject.GetComponent<Animator>().SetTrigger("Pop");
                
            }
        }

    void Pop()
    {
        Destroy(gameObject);
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
