using UnityEngine;
using System.Collections;

#pragma warning disable 0219

public class moveto_waypoint : MonoBehaviour
{

 
    public GameObject[] wayPoints;

    public float spd;
    public float distance;

    public int currentPoint;

    private Vector3 targetPosition;

    void Start()
    {
     targetPosition = wayPoints[currentPoint].transform.position;
     //Debug.Log("Current Position = " + currentPoint + " Distance = " + Vector3.Distance(transform.position, targetPosition));
    }

    void Update()
    {
        //Checks if the distance from the object to the way point is less than distance given
        //Once true it will increment to the next point.
        if ((Vector3.Distance(transform.position, targetPosition) < distance))
        {
            nextPoint();
        }
        else
        {
         float dir = 0;
         //Moving and turning
         this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, 0.05F);
        }
    }

    private void nextPoint()
    {
        //Checks to see if it reached the max waypoint possible
        if (currentPoint >= wayPoints.Length - 1)
        {
            Debug.LogWarning("lolz im here");
            //If true sets it to 0 so array doesn't go out of bounds.
            currentPoint = 0;
        }
        else
            currentPoint++;
        //Sets the the targetPosition to the next waypoint.
        targetPosition = wayPoints[currentPoint].transform.position;
        Debug.Log("Current Position = " + currentPoint + " Distance = " + Vector3.Distance(transform.position, targetPosition));


    }
}
