/***
 * Author: Rain Baldridge
*   Date Created: 11/8/21
*   Date Modified: 11/8/21
*   Description: Follow Destination test Navigation for Baby
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class BabyDestination : MonoBehaviour
{
    /*** variables ***/
    public Transform Destination = null;
    private NavMeshAgent ThisAgent = null;

    private void Awake()
    {
        ThisAgent = GetComponent<NavMeshAgent>();
    } // end Awake()

    private void Update()
    {
        ThisAgent.SetDestination(Destination.position);
    } // end Update()
}
