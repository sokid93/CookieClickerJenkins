using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public class PurchaseAutoclickerUpgrade
    {
        private readonly CookieClicker cookieClicker;
        private readonly IOutputCounter outputCounter;

        public PurchaseAutoclickerUpgrade(CookieClicker cookieClicker, IOutputCounter outputCounter)
        {
            this.cookieClicker = cookieClicker;
            this.outputCounter = outputCounter;
        }

        public void Execute()
        {
            var upgradeCost = 1;
            if (!cookieClicker.CanSpendCookies(upgradeCost)) return;
        
            cookieClicker.SpendCookies(upgradeCost);
            cookieClicker.UpgradeAutoclickerRate();
            outputCounter.UpdateCounter(cookieClicker.Cookies);
        }
    }
}