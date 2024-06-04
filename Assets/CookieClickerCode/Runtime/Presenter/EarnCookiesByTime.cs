using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;
        private readonly CookieClicker cookieClicker;
        private DateTime lastKnownTime;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter, CookieClicker cookieClicker)
        {
            this.earnCookiePresenter = earnCookiePresenter;
            this.cookieClicker = cookieClicker;
        }

        public void Execute(DateTime dateTime)
        {
            if (!MustEarnCookie(dateTime)) return;
            
            earnCookiePresenter.Execute();
            lastKnownTime = dateTime;
        }

        private bool MustEarnCookie(DateTime dateTime)
        {
            return cookieClicker.ClicksPerSecond > 0 && ((dateTime - lastKnownTime).TotalSeconds >= 1/(cookieClicker.ClicksPerSecond)) ;
        }
    }
}