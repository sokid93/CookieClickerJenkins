using UnityEngine;

public class PurchaseUpgradeButton : MonoBehaviour

{
    private PurchaseUpgrade presenter;

    public void Configure(PurchaseUpgrade presenter)
    {
        this.presenter = presenter;
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
