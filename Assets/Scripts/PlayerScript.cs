using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int lv = 1;

    public int exp = 0;

    public int currentExp = 0;

    public int skillPoint = 0;
    
    public int hp = 10;


    public int moveSpeed = 5;

    public int attack = 5;

    public int defence = 1;

    public Rigidbody2D rb;

    Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       if (Input.GetKeyDown("space"))
        {
            hp -= 5;
        }

        Die();
    }

     void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void Die()
    {
        if(hp == 0.0f)
        {
            Debug.Log("DIED");
        }
    }
}


