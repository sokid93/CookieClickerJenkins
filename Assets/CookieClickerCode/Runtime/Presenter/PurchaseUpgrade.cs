
using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class PurchaseUpgrade
    {
        private readonly CookieClicker cookieClicker;
        private readonly IOutputCounter outputCounter;

        public PurchaseUpgrade(CookieClicker cookieClicker, IOutputCounter outputCounter)
        {
            this.cookieClicker = cookieClicker;
            this.outputCounter = outputCounter;
        }

        public void Execute()
        {
            var upgradeCost = 1;
            if (!cookieClicker.CanSpendCookies(upgradeCost)) return;
        
            new CookiesX2Upgrade(cookieClicker,upgradeCost).ApplyUpgrade();
            outputCounter.UpdateCounter(cookieClicker.Cookies);
        }
    }
}
