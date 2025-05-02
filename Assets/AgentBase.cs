using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBase : MonoBehaviour

{
    [SerializeField] GameObject _joueur;
    NavMeshAgent _agent;

  
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(_joueur.transform.position);
    }
}
