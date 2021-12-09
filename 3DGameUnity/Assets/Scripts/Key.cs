/*** 
 *  Created by: Rain Baldridge
 *  Date Created: 12/01/21
 *  Modified: 12/01/21
 *  Description: Behavior for key pickups.
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    /*** variables ***/
    public static int keyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Find the keys to escape.");
        Key.keyCount++; // increment keyCount
        Debug.Log("Keys Found: " + keyCount);
    } // end Start()

    // Update is called once per frame
    void Update()
    {
        
    } // end Update()

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered.");
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject); // destroys key
        }
        
    } // end OnTriggerEnter()

    void OnDestroy()
    {
        ++Key.keyCount;
        
        if(Key.keyCount > 0)
        {
            Debug.Log("Keys Found.");
        }
    } // end OnDestroy()
}
