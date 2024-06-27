using System.Collections;
using System.Collections.Generic;
using CookieClickerCode.Runtime.View;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class ViewTest
{
    [UnityTest]
    public IEnumerator ClickingOneTimeGivesOneCookie()
    {
        // Cargar la escena
        yield return SceneManager.LoadSceneAsync(0);
        yield return null;
        EarnCookie();
        Assert.AreEqual("1", Object.FindObjectOfType<CookiesButtonAndCounter>().GetComponentInChildren<TextMeshProUGUI>().text);
    }

    [UnityTest]
    public IEnumerator TestAutoclickerAfterSomeSeconds()
    {

        // Cargar la escena
        yield return SceneManager.LoadSceneAsync(0);
        yield return null;

        EarnCookie();

        Object.FindObjectOfType<PurchaseAutoclickerUpgradeButton>().GetComponent<Button>().onClick.Invoke();
        yield return new WaitForSeconds(5.1f);
        Assert.AreEqual("6", Object.FindObjectOfType<CookiesButtonAndCounter>().GetComponentInChildren<TextMeshProUGUI>().text);

        Time.timeScale = 1;
    }

    private static void EarnCookie()
    {
        Object.FindObjectOfType<CookiesButtonAndCounter>().GetComponent<Button>().onClick.Invoke();
    }
}
