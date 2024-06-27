using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class EarnCookiesByTime
    {
        private readonly EarnCookie earnCookiePresenter;
        private readonly Autoclicker timer;

        public EarnCookiesByTime(EarnCookie earnCookiePresenter, Autoclicker timer)
        {
            this.earnCookiePresenter = earnCookiePresenter;
            this.timer = timer;
        }

        public void Execute(DateTime dateTime)
        {
            if (!timer.MustAutoclick(dateTime)) return;
            earnCookiePresenter.Execute();
            timer.AccumulateTime(dateTime);
        }
    }
}