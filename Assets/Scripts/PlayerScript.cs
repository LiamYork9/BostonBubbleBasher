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

    public int currentHP;
    public int moveSpeed = 5;

    public int attack = 5;

    public int defense = 1;

    public Rigidbody2D rb;

    public CameraMove moveCamera;

    public Text lvText;

    public Text spText;

    public Text healthText;

    public bool shieldUnlocked;

    public bool soapUnlocked;

    Vector2 movement;

    public GameObject deathScreen;

    public int killCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = hp;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown("space")&&shieldUnlocked)
        {
            GameObject temp = (Instantiate(GameManager.Instance.bubbleShield,transform.position,transform.rotation));
            temp.transform.parent = GameManager.Instance.player.transform;
            
        }
        if (Input.GetKeyDown("f")&&soapUnlocked)
        {
            //call soap script
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
            gameObject.GetComponent<SpriteRenderer>().flipX=true;
        }
        else if (movement.x>0 && !stayFacing)
        {
            facing = 1;
             gameObject.GetComponent<SpriteRenderer>().flipX=false;
        }



        if(movement.x>0.2f||movement.x<-0.2f||movement.y>0.2f||movement.y<-0.2f)
        {
            gameObject.GetComponent<Animator>().SetBool("Moving", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Moving", false);
        }
        
        Die();

        if(Input.GetKeyDown(KeyCode.R))
     {
        currentExp = currentExp+10;
     }

     LevelUp();
        lvText.text = "LV: " + lv;
        spText.text = "Skill Points: " + skillPoint;
        healthText.text = "HP: " + currentHP;
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
        if(currentHP <= 0.0f)
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
            GameManager.Instance.UpdateLVL(GameManager.Instance.lv+1);
            currentExp = 0;
            GameManager.Instance.UpdateSkillPoint(GameManager.Instance.skillPoint+1);
        }
    }
}


