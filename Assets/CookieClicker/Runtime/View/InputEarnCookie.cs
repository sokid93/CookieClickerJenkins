using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEarnCookie : MonoBehaviour
{
    private void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
    }

    void PressButton()
    {
        
    }
}
