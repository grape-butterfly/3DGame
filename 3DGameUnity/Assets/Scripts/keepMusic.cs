using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);  
    }
}
