
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class PurchaseCookiesX2Upgrade
    {
        private readonly CookieClicker cookieClicker;
        private readonly IOutputCounter outputCounter;

        public PurchaseCookiesX2Upgrade(CookieClicker cookieClicker, IOutputCounter outputCounter)
        {
            this.cookieClicker = cookieClicker;
            this.outputCounter = outputCounter;
        }

        public void Execute()
        {
            var upgradeCost = 1;
            if (!cookieClicker.CanSpendCookies(upgradeCost)) return;
        
            cookieClicker.SpendCookies(upgradeCost);
            cookieClicker.UpgradeMultiplier();
            outputCounter.UpdateCounter(cookieClicker.Cookies);
        }
    }
}
