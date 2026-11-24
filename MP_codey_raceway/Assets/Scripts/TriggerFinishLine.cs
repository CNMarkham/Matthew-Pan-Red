using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                SceneManager.LoadScene(2);
            }
            else
            {
                print("get gud");
            }
        }
    }
}
