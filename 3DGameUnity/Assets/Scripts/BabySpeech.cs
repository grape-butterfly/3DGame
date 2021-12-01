/***
 * Created by: Rain Baldridge
 * Date: 11/29/21
 * Modified: 12/1/21
 * Description: Text box speak for baby head. 
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabySpeech : MonoBehaviour
{
    /*** variables ***/
    [SerializeField]
    private string[] speech;
    [SerializeField]
    bool repeat = false;
    private int spokenStrings = 0;
    private Text textPanel;
    // Start is called before the first frame update
    void Start()
    {
        textPanel = GetComponentInChildren<Text>();
    } // end Start()

    private void OnTriggerEnter(Collider other)
    {
        if(spokenStrings < speech.Length)
        {
            Speak(speech[spokenStrings]);
            spokenStrings++;
        }
    } // end OnTriggerEnter()

    void Speak(string sayThings)
    {
        textPanel.text = sayThings;
        textPanel.gameObject.SetActive(true);
    } // end Speak()
}
