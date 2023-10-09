using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{
    int currentIndex = -1;
    public Patrol (GameObject _npc, UnityEngine.AI.NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.PATROL;
        agent.speed = 2;
        agent.isStopped = false;
    }

    public override void Enter()
    {
        anim.SetTrigger("isWalking");
        base.Enter();
    }
    public override void Update()
    {
        if(agent.remainingDistance < 1)
        {
            if (currentIndex > GameEnvironment.Singleton.Checkpoints.Count - 1)
                currentIndex = 0;
            else
                currentIndex++;

            agent.SetDestination(GameEnvironment.Singleton.Checkpoints[currentIndex].transform.position);
        }
        
    }
    public override void Exit()
    {
        anim.ResetTrigger("isWalking");
        base.Exit();
    }
}
