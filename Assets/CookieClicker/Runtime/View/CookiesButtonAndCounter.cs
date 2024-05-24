using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class CookiesButtonAndCounter : MonoBehaviour, IOutputCounter
{
    private EarnCookie presenter;
    private CookieClicker model;
    public void Configure(CookieClicker model, EarnCookie presenter)
    {
        this.model = model;
        this.presenter = presenter;
    }

    private void Start()
    {
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
