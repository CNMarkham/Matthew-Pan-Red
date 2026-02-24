using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherBehavior : MonoBehaviour
{
    public float speed;
    public int maximumXPosition;
    public int minimumXPosition;
    public void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition || transform.position.x >= maximumXPosition)
        {
            speed *= -1;
        }
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
