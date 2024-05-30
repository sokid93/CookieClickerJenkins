using CookieClickerCode.Runtime.Domain;

namespace CookieClickerCode.Runtime.Presenter
{
    public interface IOutputCounter
    {
        void UpdateCounter(int cookies);
    }

    public class EarnCookie
    {
        CookieClicker cookieClicker;
        private readonly IOutputCounter outputCounter;

        public EarnCookie(CookieClicker cookieClicker, IOutputCounter outputCounter)
        {
            this.cookieClicker = cookieClicker;
            this.outputCounter = outputCounter;
        }

        public void Execute()
        {
            cookieClicker.EarnCookie();
            outputCounter.UpdateCounter(cookieClicker.Cookies);
        }
    }
}