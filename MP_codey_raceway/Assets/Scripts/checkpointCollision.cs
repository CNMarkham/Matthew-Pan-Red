using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{
    public bool didCollide;
    public checkpointCounter count;
    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player") && didCollide == false)
        {
            count.triggeredCheckpoints++;
            didCollide = true;
            print("checkpoint touched");
        }
    }
}
