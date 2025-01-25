using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int lv = 1;
    public int facing = 1;

    public bool stayFacing = false;

    public int exp = 0;

    public int currentExp = 0;

    public int skillPoint = 0;
    
    public int hp = 10;
    public int moveSpeed = 5;

    public int attack = 5;

    public int defence = 1;

    public Rigidbody2D rb;

    public CameraMove moveCamera;

    public Text lvText;

    public Text spText;

    Vector2 movement;

    public GameObject deathScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            stayFacing = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            stayFacing = false;
        }

        if(movement.x<0 && !stayFacing)
        {
            facing = -1;
        }
        else if (movement.x>0 && !stayFacing)
        {
            facing = 1;
        }
        
        Die();

        if(Input.GetKeyDown(KeyCode.R))
     {
        currentExp = currentExp+10;
     }

     LevelUp();
        lvText.text = "LV: " + lv;
        spText.text = "Skill Points: " + skillPoint;

    }

     void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.CompareTag("TargetArea")) 
        {
             moveCamera.begin = true;
        }

        if(other.gameObject.CompareTag("TargetArea2"))
        {
             moveCamera.begin2 = true;
        }
    }
       
    

    public void Die()
    {
        if(hp == 0.0f)
        {
            deathScreen.SetActive(true);
            Debug.Log("DIED");
            Time.timeScale = 0.0f;
        }
    }

    public void LevelUp()
    {
        if(currentExp == (exp + 10 * lv))
        {
            lv = lv + 1;
            currentExp = 0;
            skillPoint = skillPoint + 1;
        }
    }
}


