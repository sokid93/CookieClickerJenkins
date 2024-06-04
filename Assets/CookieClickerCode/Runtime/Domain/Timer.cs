using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class Timer
    {
        private DateTime lastKnownTime;
        private readonly CookieClicker cookieClicker;


        public Timer(CookieClicker cookieClicker)
        {
            this.cookieClicker = cookieClicker;
        }

        public bool MustEarnCookie(DateTime dateTime)
        {
            return cookieClicker.ClicksPerSecond > 0 && ((dateTime - lastKnownTime).TotalSeconds >= 1/(cookieClicker.ClicksPerSecond)) ;
        }
    }
}