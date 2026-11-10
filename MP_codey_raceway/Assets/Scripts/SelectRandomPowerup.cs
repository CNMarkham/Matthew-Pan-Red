using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public float spawnDistance = 2f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (chosenPowerup == powerupList[0] || chosenPowerup == powerupList[1])
            {
                Vector3 spawnPosition = transform.position + (transform.forward * spawnDistance);
                Instantiate(chosenPowerup, spawnPosition, transform.rotation);
            }
            else
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    Vector3 spawnPosition = hit.point;
                    spawnPosition.y += 400f;
                    Instantiate(chosenPowerup, spawnPosition, transform.rotation);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lootboxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
