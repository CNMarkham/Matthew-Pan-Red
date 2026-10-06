using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootboxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 10, 10));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawner", 5);
        }
    }
    private void itemBoxRespawner()
    {
        gameObject.SetActive(true);
    }
}
