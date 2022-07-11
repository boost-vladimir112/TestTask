using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool _fight;

    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
 
    void Start()
    {   
        _fight = false;
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1 )
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
        if(_fight)
        {
            agent.isStopped = true;
            GetComponent<Animation>().IdleAnim();
        }
        else
        {
            agent.isStopped = false;
            GetComponent<Animation>().RunAnim();
        }
      
    }
    void UpdateDestination()
    {
            target = waypoints[waypointIndex].position;
            agent.SetDestination(target);
            
    }
    void IterateWaypointIndex()
    {
            waypointIndex++;
            _fight = true;
            
            Debug.Log("New point" + waypointIndex);

        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            SceneManager.LoadScene(0);
        }
    }

}
