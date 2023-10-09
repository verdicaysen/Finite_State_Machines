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
}
