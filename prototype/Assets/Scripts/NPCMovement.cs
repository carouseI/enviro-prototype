using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>(); //find nac mesh comp

        if (_navMeshAgent == null) //if null
        {
            Debug.LogError("nav mesh comp not attached to " + gameObject.name); //show msg
        }
        else
        {
            SetDestination();
        }

    }

    private void SetDestination()
    {
        if (_destination != null) //if destination has been set
        {
            Vector3 targetVector = _destination.transform.position; //destination
            _navMeshAgent.SetDestination(targetVector); //set agent on destination
        }
    }
}