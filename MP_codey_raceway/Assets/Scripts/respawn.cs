using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("terrain"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
