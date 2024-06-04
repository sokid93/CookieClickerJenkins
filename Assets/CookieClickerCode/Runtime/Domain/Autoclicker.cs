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
            return cookieClicker.ClicksPerSecond > 0 && ((dateTime - lastKnownTime).TotalSeconds >= 1/(cookieClicker.ClicksPerSecond)) ;
        }

        public void AccumulateTime(DateTime dateTime)
        {
            lastKnownTime = dateTime;
        }
    }
}