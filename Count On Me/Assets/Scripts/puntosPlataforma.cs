using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntosPlataforma : MonoBehaviour
{
    public Transform GetWayPoint(int waypointIndex)
    {
        return transform.GetChild(waypointIndex);
    }

    public int GetNextWayPointIndex(int currentWaypointIndex)
    {
        int nextWaypointIndex = currentWaypointIndex + 1;

        if(nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }
        
        return nextWaypointIndex;
    }
}
