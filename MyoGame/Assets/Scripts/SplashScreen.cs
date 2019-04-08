using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    //Constants and Variables
    public Image splashImage;

    IEnumerator Start()
    {
        //Setting alpha to 0.0f
        splashImage.canvasRenderer.SetAlpha(0.0f);

        //Fading in and fading out splash screen
        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }

    //Method that fades in splash image
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    //Method that fades out splash image
    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
