/***
 *  Author: Rain Baldridge
 *  Date Created: 10/25/21
 *  Date Modified: 10/25/21
 *  
 *  Description: Behaviors for minimap camera, including following player.
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        Vector3 newPos = player.position; // player position
        newPos.y = transform.position.y; // resets camera y
        transform.position = newPos; // moves camera to new position
    }
}
