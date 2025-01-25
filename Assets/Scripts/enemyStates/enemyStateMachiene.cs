using StateMachine;
using UnityEngine;
using Pathfinding;
public class enemyStateMachiene : SM_StateMachine
{
    //states
    public waitinZone wait;
    public moveToPlayer move;
    public attack attack;

    //variables
    public Transform target;

    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    public Transform enemyGFX;

    public Path path;
    public int currentWaypoint = 0;
    public bool reachedEndOfPath = false;
    public Rigidbody2D rb;
    public Seeker seeker;

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
    }


    // Update is called once per frame
    void Update()
    {
        
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
}
