using UnityEngine;

public class PurchaseUpgradeButton : MonoBehaviour

{
    private PurchaseUpgrade presenter;
    private QueryCookies queryCookies;

    public void Configure(PurchaseUpgrade presenter, QueryCookies queryCookies)
    {
        this.presenter = presenter;
        this.queryCookies = queryCookies;
    }

    private void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(PressButton);
    }

    private void PressButton()
    {
        this.presenter.Execute();
    }

    private void Update()
    {
        // TODO: define queryCookies
        GetComponent<UnityEngine.UI.Button>().enabled = queryCookies.Execute();
    }
}
