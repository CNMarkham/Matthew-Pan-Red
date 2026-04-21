using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public Teleport portal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        portal = GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>();
        Invoke("DestroyThrowable", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            portal.enemyCount--;
            Destroy(collision.gameObject);
            Invoke("DestroyThrowable", 0f);
        }
    }
    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
