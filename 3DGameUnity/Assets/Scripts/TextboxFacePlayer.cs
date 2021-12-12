/***
 *  Created by: Rain Baldridge
 *  Date Created: 12/10/21
 *  Date Modified: 12/10/21
 *  Description: Force Baby Text box to always face player. 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextboxFacePlayer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
    } // end Update()
}
