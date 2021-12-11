/*** 
 *  Created by: Rain Baldridge
 *  Date Created: 12/10/21
 *  Modified: 12/10/21
 *  Description: Changes to Credit Scene. 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);  // load credit scene
    } // end OnTriggerEnter()
}
