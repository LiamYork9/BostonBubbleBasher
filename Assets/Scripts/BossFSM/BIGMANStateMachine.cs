using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

public class BIGMANStateMachine : SM_StateMachine
{
    //States
    public RandomAttack random;
    public Kick kick;

    //var
    public Transform[] points;
    public Transform curPoint;
    public float speed;
    public GameObject player;
    public GameObject kickHB;
    public Rigidbody2D rb;
    public int moveCounter;
    public int kickChance;
    public int kickNum;
    public int ranKick;
    public int randPoint;
    public GameObject Bullets;
    public timer timer;


    private void Awake()
    {
        states.Add(random);
        states.Add(kick);

        foreach (SM_State s in states)
            s.stateMachine = this;

    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        kickHB = GameObject.FindWithTag("KickZone");
        rb = GetComponent<Rigidbody2D>();
        timer = GetComponent<timer>();
        kickNum = Random.Range(1, kickChance);
        ChangeState(nameof(RandomAttack));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot(Transform _point)
    {
        Debug.Log("Shoot");
        curPoint = _point;
        if (Vector2.Distance(transform.position, _point.position) < .2f && timer.hasTime)
        {
            timer.StartTime();
            Bullets.SetActive(true);
        }
        else
        {
            Bullets.SetActive(false);
            curPoint = points[0];
            if (Vector2.Distance(transform.position, curPoint.position) < .2f)
            {
                moveCounter = 0;
                timer.ResetTime();
            }
            return;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            //player.GetComponent<PlayerScript>()
        }
    }
}
