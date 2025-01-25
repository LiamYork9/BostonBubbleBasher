using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

public class BIGMANStateMachine : SM_StateMachine
{
    //States
    public RandomAttack random;
    public ConsecutiveShooting conShooting;
    public Kick kick;

    //var
    public Transform[] points;
    public Transform curPoint;
    public float speed;
    public GameObject player;
    public GameObject gun;
    public Rigidbody2D rb;


    private void Awake()
    {
        states.Add(random);
        states.Add(conShooting);
        states.Add(kick);

        foreach (SM_State s in states)
            s.stateMachine = this;

    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        gun = GameObject.FindWithTag("BossGun");
        rb = GetComponent<Rigidbody2D>();
        curPoint = points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = curPoint.position - transform.position;
        rb.linearVelocity = dir * speed;
    }
}
