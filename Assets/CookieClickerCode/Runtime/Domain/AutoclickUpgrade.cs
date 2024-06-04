using System;
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class AutoclickUpgrade
    {
        private DateTime lastKnownTime;
        private readonly CookieClicker cookieClicker;


        public AutoclickUpgrade(CookieClicker cookieClicker)
        {
            this.cookieClicker = cookieClicker;
        }

        public bool MustAutoclick(DateTime dateTime)
        {
            return cookieClicker.ClicksPerSecond > 0 && ((dateTime - lastKnownTime).TotalSeconds >= 1/(cookieClicker.ClicksPerSecond)) ;
        }

        public void AccumulateTime(DateTime dateTime)
        {
            lastKnownTime = dateTime;
        }
    }
}