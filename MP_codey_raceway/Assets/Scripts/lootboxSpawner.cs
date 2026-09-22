using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootboxSpawner : MonoBehaviour
{
    public GameObject Lootbox;
    public int numberOfBoxes;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject lootboxClone = Instantiate(Lootbox, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
