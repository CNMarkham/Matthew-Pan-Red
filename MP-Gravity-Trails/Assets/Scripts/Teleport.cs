using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;
    public string Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (collision.gameObject.tag == "Player" && enemyCount == 0)
        {
            SceneManager.LoadScene(Level);
        }
    }
}
