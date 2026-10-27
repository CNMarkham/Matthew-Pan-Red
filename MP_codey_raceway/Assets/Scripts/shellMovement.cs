using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacles"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
