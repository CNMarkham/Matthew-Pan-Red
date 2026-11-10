using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitalStrikeCannonLockOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.down * 300;
        Invoke("delete", 5);
    }

    private void delete()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacles"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("tree"))
        {
            Destroy(other.gameObject);
        }
    }
}
