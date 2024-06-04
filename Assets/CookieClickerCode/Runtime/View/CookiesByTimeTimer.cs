using System;
using CookieClickerCode.Runtime.Presenter;
using UnityEngine;

namespace CookieClickerCode.Runtime.View
{
    public class CookiesByTimeTimer : MonoBehaviour
    {
        private EarnCookiesByTime presenter;
     
        public void Configure(EarnCookiesByTime cookiesByTime)
        {
            presenter = cookiesByTime;
        }
        
        private void Update()
        {
            presenter.Execute(DateTime.Now);
        }

    }
}