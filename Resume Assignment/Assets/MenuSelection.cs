using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
    public GameObject HiddenThings;
    public GameObject NextSceneEffect;
    public Image FadeIn;

    public void ChooseChiaLing()
    {
        Manager.instance.ChiaLing = true;
        Manager.instance.PeiYi = false;
        Manager.instance.KengLiang = false;
        Manager.instance.WarpSFX.Play();
        //SceneManager.LoadScene("Peiyi room temp");
        StartCoroutine(LoadNextScene());
    }

    public void ChoosePeiYi()
    {
        Manager.instance.ChiaLing = false;
        Manager.instance.PeiYi = true;
        Manager.instance.KengLiang = false;
        Manager.instance.WarpSFX.Play();
        //SceneManager.LoadScene("Peiyi room temp");
        StartCoroutine(LoadNextScene());
    }

    public void ChooseKengLiang()
    {
        Manager.instance.ChiaLing = false;
        Manager.instance.PeiYi = false;
        Manager.instance.KengLiang = true;
        Manager.instance.WarpSFX.Play();
        //SceneManager.LoadScene("Peiyi room temp");
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        HiddenThings.SetActive(false);
        NextSceneEffect.SetActive(true);
        yield return new WaitForSeconds(3);
        StartCoroutine(PlayEffect(1.0f, 1.0f));
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Peiyi room temp");
    }

    IEnumerator PlayEffect(float aValue, float aTime)
    {
        float alpha = FadeIn.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            FadeIn.color = newColor;
            yield return null;
        }
    }

    public void OnClickQiut()
    {
        Application.Quit();
    }
}
