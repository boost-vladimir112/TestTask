using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetComponent<Animation>().isRun);
        if (GetComponent<Animation>().isRun)
        {
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
               
            }
        }
    }
    void UpdateDestination()
    {
        //bool _isRun; 
        //_isRun = false;
        //GetComponent<Animation>().isRun = _isRun;
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    
    }
    void IterateWaypointIndex()
    {
  
        waypointIndex++;
        
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
            SceneManager.LoadScene(0);
        }
    }

}
