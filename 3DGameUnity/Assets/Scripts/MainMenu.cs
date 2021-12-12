/***
 *  Created by: Rain Baldridge
 *  Date Created: 12/10/21
 *  Date Modified: 12/10/21
 *  Description: Allows main menu functionality.
 * 
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
