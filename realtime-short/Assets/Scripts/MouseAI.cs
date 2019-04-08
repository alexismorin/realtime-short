using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouseAI : MonoBehaviour
{
    NavMeshAgent agent;
    Animator rig;
    public Transform[] waypoints;
    public string[] additiveAnimationTriggerNames;
    int index = -1;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    public void GoToNextWaypoint()
    {   
        index++;
        agent.destination = waypoints[index].position;
    }

    public void PlayAdditiveAnimation(){
        rig.SetTrigger("additiveAnimationTriggerNames");
    }
}
