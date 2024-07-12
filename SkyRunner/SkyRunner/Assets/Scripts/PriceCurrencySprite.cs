using UnityEngine;
using UnityEngine.UI;
using YG;

[DefaultExecutionOrder(-1000), RequireComponent(typeof(Image))]
public class PriceCurrencySprite : MonoBehaviour
{
    private void Awake()
    {
        if (YandexGame.priceCurrencySprite)
        {
            SetPriceCurrencySprite(YandexGame.priceCurrencySprite);
        }
        else
        {
            YandexGame.PriceCurrencySpriteEvent += SetPriceCurrencySprite;
        }
    }

    private void SetPriceCurrencySprite(Sprite currencySprite)
    {
        var priceCurrencyImage = GetComponent<Image>();
        priceCurrencyImage.sprite = currencySprite;
        priceCurrencyImage.preserveAspect = true;
        YandexGame.PriceCurrencySpriteEvent -= SetPriceCurrencySprite;
        Destroy(this);
    }
}