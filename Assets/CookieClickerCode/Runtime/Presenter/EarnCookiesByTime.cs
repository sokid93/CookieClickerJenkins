using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;
        private readonly Autoclicker timer;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter, CookieClicker cookieClicker)
        {
            this.earnCookiePresenter = earnCookiePresenter;
            timer = new Autoclicker(cookieClicker);
        }

        public void Execute(DateTime dateTime)
        {
            if (!timer.MustAutoclick(dateTime)) return;
            earnCookiePresenter.Execute();
            timer.AccumulateTime(dateTime);
        }
    }
}