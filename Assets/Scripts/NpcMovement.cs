using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 2f;

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length > 0)
        {
            // Move towards the current waypoint
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);


            // Check if the NPC has reached the current waypoint
            if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {
                // Move to the next waypoint

             //Check if the NPC has reached the current waypoint
            if (transform.position == waypoints[currentWaypointIndex].position)
            {
                //Move to the next waypoint

                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
        }
    }

}

}

