using UnityEngine.AI;
using UnityEngine;

public class AINavigation : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update () 
    {
        agent.SetDestination(target.position);	
	}
}
