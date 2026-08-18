using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public checkpointCounter checkpoointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            if (checkpoointTracker.triggeredCheckpoints == checkpoointTracker.numberOfCheckpoints)
            {
                print("You Win!");
            }
            else
            {
                print("placeholder");
            }
        }
    }
}
