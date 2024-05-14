using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputEarnCookie : MonoBehaviour
{
    private EarnCookie presenter;
    private CookieClicker model;
    
    private void Start()
    {
        model = new CookieClicker();
        presenter = new EarnCookie(model, null);
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
    }

    void PressButton()
    {
        presenter.Execute();
    }
}
