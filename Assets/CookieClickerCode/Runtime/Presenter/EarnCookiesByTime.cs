using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;
        private readonly Timer timer;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter, CookieClicker cookieClicker)
        {
            this.earnCookiePresenter = earnCookiePresenter;
            timer = new Timer(cookieClicker);
        }

        public void Execute(DateTime dateTime)
        {
            if (!timer.MustEarnCookie(dateTime)) return;
            earnCookiePresenter.Execute();
            timer.AccumulateTime(dateTime);
        }
    }
}