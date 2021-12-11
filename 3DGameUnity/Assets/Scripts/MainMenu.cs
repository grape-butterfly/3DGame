/***
 *  Created By: Rain Baldridge 
 *  Date Created: 12/07/21
 *  Date Modified: 12/08/21
 *  Description: Functionality for Main Menu
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Greybox");
    } // end Play()

    public void Quit()
    {
        Application.Quit();
    } // end Quit()
}
