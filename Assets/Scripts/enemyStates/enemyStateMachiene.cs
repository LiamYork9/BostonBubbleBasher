using StateMachine;
using UnityEngine;
using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;

public class enemyStateMachiene : SM_StateMachine
{
    //states
    public waitinZone wait;
    public moveToPlayer move;
    public attack attack;

    //variables
    public EnemyManager enemyManager;
    public Circle2DCollider attackRange;
    public List<GameObject> attackingList;

    public Transform target;

    public float speed = 200f;
    public float baseSpeed = 200f;
    public float nextWaypointDistance = 3f;

    public Transform enemyGFX;

    public Path path;
    public int currentWaypoint = 0;
    public bool reachedEndOfPath = false;
    public Rigidbody2D rb;
    public Seeker seeker;

    public GameObject WaitingZone;
    public GameObject AttackZone;
    public bool isWaiting = false;
    public bool isAttacking = false;
    public bool nextInQueue = false;
    public timer timer;
    public int damage;
    public bool inRange = false;

    public Vector2 directon;
    public Vector2 force;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        states.Add(wait);
        states.Add(move);
        states.Add(attack);

        foreach(SM_State s in states)
            s.stateMachine = this;
    }
    void Start()
    {
        ChangeState(nameof(moveToPlayer));
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        WaitingZone = GameObject.FindWithTag("WaitArea");
        AttackZone = GameObject.FindWithTag("EnemyAttackArea");
        timer = GetComponent<timer>();
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
    }


    // Update is called once per frame
    void Update()
    {
        AddToList();
        if (path == null)
            return;

        if (currentWaypoint >= path.vectorPath.Count || (isWaiting && !isAttacking))
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        directon = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        force = directon * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }

        if (rb.linearVelocity.x >= 0.01f)
        {
            enemyGFX.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (rb.linearVelocity.x <= -0.01f)
        {
            enemyGFX.localScale = new Vector3(1f, 1f, 1f);
        }
        
    }
      void UpdatePath()
    {
        if(seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0; 
        }
    }
    public void doneWaiting()
    {
        ChangeState(nameof(attack));
    }

    public void Attack()
    {
        Debug.Log("Attacked");
        foreach(GameObject col in attackingList)
            col.GetComponent<PlayerScript>().curretnHP -= damage;
    }
    public void AddToList()
    {
        attackingList.Clear();
        for (int i = 0; i < attackRange.enemyQueue.Count; i++)
        {
            attackingList.Add(attackRange.enemyQueue[i].attachedRigidbody.gameObject);
        }
    }
    
}
