using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int ammunitionAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pick Up"))
        {
            if (ammunitionAmount > 0) {
                offset = transform.localScale.x * new Vector3(1, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                GameObject bullet = Instantiate(objectThrown, throwablePosition, Quaternion.identity);
                bullet.transform.Rotate(0, 90, 0);
                ammunitionAmount -= 1;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectables"))
        {
            ammunitionAmount += 5;
            Destroy(collision.gameObject);
        }
    }
}
