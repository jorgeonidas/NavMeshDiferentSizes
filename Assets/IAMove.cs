using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAMove : MonoBehaviour {
    NavMeshAgent agent;
    GameObject Player;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }
	
    void Update()
    {
        if(Vector3.Distance(transform.position,Player.transform.position) > agent.stoppingDistance)
            agent.destination = Player.transform.position;
    }

}
