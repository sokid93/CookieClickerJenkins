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
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ClickingOneTimeGivesOneCookie()
    {
        // Cargar la escena
        yield return SceneManager.LoadSceneAsync(0);
        yield return null;
        Object.FindObjectOfType<CookiesButtonAndCounter>().GetComponent<Button>().onClick.Invoke();
        Assert.AreEqual("1", Object.FindObjectOfType<CookiesButtonAndCounter>().GetComponentInChildren<TextMeshProUGUI>().text);
    }
}
