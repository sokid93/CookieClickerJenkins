using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class CookiesButtonAndCounter : MonoBehaviour, IOutputCounter
{
    private EarnCookie presenter;
    private CookieClicker model;
    
    private void Start()
    {
        model = new CookieClicker();
        presenter = new EarnCookie(model, this);
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
    }

    void PressButton()
    {
        presenter.Execute();
    }

    public void UpdateCounter(int cookies)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = cookies.ToString();
    }
}
