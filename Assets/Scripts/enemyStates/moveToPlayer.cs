using Pathfinding;
using StateMachine;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class moveToPlayer : SM_State
{
    public override void OnStart()
    {
        base.OnStart();
        ((enemyStateMachiene)stateMachine).seeker = ((enemyStateMachiene)stateMachine).GetComponent<Seeker>();
        ((enemyStateMachiene)stateMachine).rb = ((enemyStateMachiene)stateMachine).GetComponent<Rigidbody2D>();

        ((enemyStateMachiene)stateMachine).InvokeRepeating("UpdatePath", 0f, .5f);
       
    }
    public override void UpdateState(float _dt)
    {
        base.UpdateState(_dt);
         if (((enemyStateMachiene)stateMachine).path == null)
            return;
        
        if(((enemyStateMachiene)stateMachine).currentWaypoint >= ((enemyStateMachiene)stateMachine).path.vectorPath.Count)
        {
            ((enemyStateMachiene)stateMachine).reachedEndOfPath = true;
            return;
        }else{
            ((enemyStateMachiene)stateMachine).reachedEndOfPath = false;
        }

        Vector2 directon = ((Vector2)((enemyStateMachiene)stateMachine).path.vectorPath[((enemyStateMachiene)stateMachine).currentWaypoint] - ((enemyStateMachiene)stateMachine).rb.position).normalized;
        Vector2 force = directon * ((enemyStateMachiene)stateMachine).speed * Time.deltaTime;
        ((enemyStateMachiene)stateMachine).rb.AddForce(force);
        float distance = Vector2.Distance(((enemyStateMachiene)stateMachine).rb.position, ((enemyStateMachiene)stateMachine).path.vectorPath[((enemyStateMachiene)stateMachine).currentWaypoint]);

        if (distance < ((enemyStateMachiene)stateMachine).nextWaypointDistance)
        {
            ((enemyStateMachiene)stateMachine).currentWaypoint++;
        }

        if(((enemyStateMachiene)stateMachine).rb.linearVelocity.x >= 0.01f)
        {
            ((enemyStateMachiene)stateMachine).enemyGFX.localScale = new Vector3(-1f, 1f,1f);
        } else if (((enemyStateMachiene)stateMachine).rb.linearVelocity.x <= -0.01f)
        {
            ((enemyStateMachiene)stateMachine).enemyGFX.localScale = new Vector3(1f, 1f,1f);
        }

        if (((enemyStateMachiene)stateMachine).isWaiting == true)
        {
            ((enemyStateMachiene)stateMachine).ChangeState(nameof(waitinZone));
        }
    }
    public override void OnExit()
    {
        base.OnExit();
    }

    
}
