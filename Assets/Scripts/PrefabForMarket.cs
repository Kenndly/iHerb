using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrefabForMarket : MonoBehaviour
{
    public string NameOfProduct;
    public TextMeshProUGUI NameOfProductTMP;
    public string SecondNameOfProduct;
    public string TextOfProduct;
    public Image ImageOfProduct;
    public UiController UiController;
    void Start()
    {
        UiController = GameObject.Find("Canvas").GetComponent<UiController>();
        NameOfProductTMP.text = NameOfProduct;
    }

    public void UpdateImageAndTextInFullInfo()
    {
        UiController.BlurBackGroundMarket.SetActive(true);
        UiController.NameInMarketFullInfo.text = NameOfProduct;
        UiController.SecondNameInMarketFullInfo.text = SecondNameOfProduct;
        UiController.DescriptionInMarketFullInfo.text = TextOfProduct;
        UiController.ImageInMarketFullInfo.sprite = ImageOfProduct.sprite;
    }

}
