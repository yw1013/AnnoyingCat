using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MouseAI : MonoBehaviour {

    public GameObject[] waypoints;
    public int currWaypoint = -1;
    public NavMeshAgent agent;
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        SetNextWaypoint();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SetNextWaypoint() {
        currWaypoint = currWaypoint + 1;
        agent.SetDestination(waypoints[currWaypoint].transform.position);
    }
}
