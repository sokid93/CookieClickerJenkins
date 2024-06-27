using System;

namespace CookieClickerCode.Runtime.Domain
{
    public class Autoclicker
    {
        private DateTime lastKnownTime;
        private readonly CookieClicker cookieClicker;


        public Autoclicker(CookieClicker cookieClicker)
        {
            this.cookieClicker = cookieClicker;
        }

        public bool MustAutoclick(DateTime dateTime)
        {
            return UpgradeBought() && 
                   ((dateTime - lastKnownTime).TotalSeconds >= 1f/(cookieClicker.ClicksPerSecond)) ;
        }

        public bool UpgradeBought()
        {
            return cookieClicker.ClicksPerSecond > 0;
        }

        public void AccumulateTime(DateTime dateTime)
        {
            lastKnownTime = dateTime;
        }
    }
}