using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    int keyCount = 0;
    void Start()
    {
        Debug.Log("Find the keys to escape.");
        Debug.Log("Keys Found: " + keyCount);
    } // end Start()

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // destroys key
        }
    }
}
