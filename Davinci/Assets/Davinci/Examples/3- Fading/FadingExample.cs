﻿using UnityEngine;
using UnityEngine.UI;

public class FadingExample : MonoBehaviour
{
    public Image image_1;
    public Image image_2;
    public Image image_3;

    public Sprite loadingSpr, errorSpr;

    public string url;

    private void Start()
    {
        //Use setFadeTime to set fading animation time. Set 0 for disable fading.

        Davinci.get()
            .load(url)
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .into(image_1)
            .setFadeTime(2)
            .start();

        Davinci.get()
            .load(url)
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .into(image_2)
            .setFadeTime(5)
            .start();

        Davinci.get()
            .load(url)
            .setFadeTime(0)//disable fading
            .setLoadingSprite(loadingSpr)
            .setErrorSprite(errorSpr)
            .into(image_3)
            .start();
    }
}