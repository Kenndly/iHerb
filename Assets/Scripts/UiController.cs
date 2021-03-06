using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public GameObject[] ObjectForFirstLaunc = new GameObject[4];
    [Space]
    public TMP_InputField SurName;
    public TMP_InputField Name;
    public TMP_InputField DateOfBirth;
    public TMP_InputField Gender;
    public TMP_InputField Height;
    public TMP_InputField Weight;
    [Space]
    public TextMeshProUGUI SurNameText;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI DateOfBirthText;
    public TextMeshProUGUI GenderText;
    public TextMeshProUGUI HeigthText;
    public TextMeshProUGUI WeightText;
    [Space]
    public TextMeshProUGUI FirstAnalysText;
    public TextMeshProUGUI SecondAnalysText;
    public TextMeshProUGUI ThirdAnalysText;
    public TextMeshProUGUI FourthAnalysText;
    public TextMeshProUGUI FivethAnalysText;
    public TextMeshProUGUI SixthAnalysText;
    [Space]
    public TMP_InputField FirstAnalys;
    public TMP_InputField SecondAnalys;
    public TMP_InputField ThirdAnalys;
    public TMP_InputField FourthAnalys;
    public TMP_InputField FivethAnalys;
    public TMP_InputField SixthAnalys;
    [Space]
    public CanvasGroup Analys;
    public TextMeshProUGUI Description;
    public GameObject BlurBackGround;
    public GameObject BlurBackGroundMarket;
    public TextMeshProUGUI DescriptionInMarketFullInfo;
    public TextMeshProUGUI NameInMarketFullInfo;
    public TextMeshProUGUI SecondNameInMarketFullInfo;
    public Image ImageInMarketFullInfo;
    public CanvasGroup FAQ;
    public CanvasGroup Market;
    public CanvasGroup Profile;
    public List<Product> products = new List<Product>();
    public GameObject prefabofproduct;
    public GameObject PlaceForProducts;
    public TMP_InputField ProductField;
    public TextMeshProUGUI CheckesText;
    public enum MainScreen
    {
        FAQ,
        Market,
        Profile
    }
    public void createProduct()
    {
        if (ProductField.text.Length > 1)
        {
            var _object = Instantiate(prefabofproduct, PlaceForProducts.transform);
            _object.GetComponent<Product>().ProductName = ProductField.text;
            _object.GetComponent<Product>().UpdateTextAndComponents();
            ProductField.text = string.Empty;
        }
    }
    public void Check()
    {
        CheckesText.text = string.Empty;
        int k = 0;
        for (int i = 0; i < products.Count; i++)
        {
            foreach (Product product in products)
            {
                if (products[i].BadComponnets.Contains(product.ProductName.ToLower()))
                {
                    CheckesText.text += products[i].ProductName + " ??????????? ? " + product.ProductName.ToLower() + "\n";
                    k++;
                }
            }
        }
        if (k == 0 && products.Count > 1)
        {

            CheckesText.text = "????????????? ??????????? ??????? ?? ????";
        }
        if (k == 0 && products.Count < 2)
        {
            CheckesText.text = "??? ???????? ????? ?????? 1 ??????????";
        }
    }
    public void OnBoradingosOver()
    {
        PlayerPrefs.SetInt("FirstlauncIsOver", 1);
    }
    public MainScreen screen;
    private void Start()
    {
        if (PlayerPrefs.GetInt("FirstlauncIsOver") == 1)
        {
            foreach (var item in ObjectForFirstLaunc)
            {
                item.SetActive(false);
            }
        }
        UpdateAnalys();
        UpdateParametrs();

    }
    public void ChangeScreenInMainMenu(string ScreenName)
    {
        switch (ScreenName)
        {
            case "FAQ":
                switch (screen)
                {
                    case MainScreen.FAQ:
                        FAQ.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.FAQ;
                        break;
                    case MainScreen.Market:
                        Market.GetComponent<RectTransform>().DOAnchorPos(new Vector2(1500, 0), 1f).SetEase(Ease.OutCubic);
                        FAQ.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.FAQ;
                        break;
                    case MainScreen.Profile:
                        Profile.GetComponent<RectTransform>().DOAnchorPos(new Vector2(1500, 0), 1f).SetEase(Ease.OutCubic);
                        FAQ.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.FAQ;
                        break;
                }
                break;
            case "Market":
                switch (screen)
                {
                    case MainScreen.FAQ:
                        Market.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        FAQ.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-1500, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Market;
                        break;
                    case MainScreen.Market:
                        Market.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Market;
                        break;
                    case MainScreen.Profile:
                        Profile.GetComponent<RectTransform>().DOAnchorPos(new Vector2(1500, 0), 1f).SetEase(Ease.OutCubic);
                        Market.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Market;
                        break;
                }
                break;
            case "Profile":
                switch (screen)
                {
                    case MainScreen.FAQ:
                        FAQ.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-1500, 0), 1f).SetEase(Ease.OutCubic);
                        Profile.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Profile;
                        break;
                    case MainScreen.Market:
                        Market.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-1500, 0), 1f).SetEase(Ease.OutCubic);
                        Profile.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Profile;
                        break;
                    case MainScreen.Profile:
                        Profile.GetComponent<RectTransform>().DOAnchorPos(new Vector2(0, 0), 1f).SetEase(Ease.OutCubic);
                        screen = MainScreen.Profile;
                        break;
                }
                break;
        }

    }
    public void AnalysOff()
    {
        Analys.DOFade(0, 1);
        Analys.interactable = false;
        Analys.blocksRaycasts = false;
    }
    public void AnalysON()
    {
        Analys.DOFade(1, 1);
        Analys.interactable = true;
        Analys.blocksRaycasts = true;
    }
    public void SaveAnalyses()
    {
        PlayerPrefs.SetString("FirstAnalys", FirstAnalys.text);
        PlayerPrefs.SetString("SecondAnalys", SecondAnalys.text);
        PlayerPrefs.SetString("ThirdAnalys", ThirdAnalys.text);
        PlayerPrefs.SetString("FourthAnalys", FourthAnalys.text);
        PlayerPrefs.SetString("FivethAnalys", FivethAnalys.text);
        PlayerPrefs.SetString("SixthAnalys", SixthAnalys.text);
        UpdateAnalys();
    }

    public void UpdateAnalys()
    {
        if (PlayerPrefs.GetString("FirstAnalys").Length > 1)
        {
            FirstAnalysText.text = "1. " + PlayerPrefs.GetString("FirstAnalys");
        }
        else
        {
            SecondAnalysText.text = "1. ?? ?????????";
        }
        if (PlayerPrefs.GetString("SecondAnalys").Length > 1)
        {
            SecondAnalysText.text = "2. " + PlayerPrefs.GetString("SecondAnalys");
        }
        else
        {
            SecondAnalysText.text = "2. ?? ?????????";
        }
        if (PlayerPrefs.GetString("ThirdAnalys").Length > 1)
        {
            ThirdAnalysText.text = "3. " + PlayerPrefs.GetString("ThirdAnalys");
        }
        else
        {
            ThirdAnalysText.text = "3. ?? ?????????";
        }
        if (PlayerPrefs.GetString("FourthAnalys").Length > 1)
        {
            FourthAnalysText.text = "4. " + PlayerPrefs.GetString("FourthAnalys");
        }
        else
        {
            FourthAnalysText.text = "4. ?? ?????????";
        }
        if (PlayerPrefs.GetString("FivethAnalys").Length > 1)
        {
            FivethAnalysText.text = "5. " + PlayerPrefs.GetString("FivethAnalys");
        }
        else
        {
            FivethAnalysText.text = "5. ?? ?????????";
        }
        if (PlayerPrefs.GetString("SixthAnalys").Length > 1)
        {
            SixthAnalysText.text = "6. " + PlayerPrefs.GetString("SixthAnalys");
        }
        else
        {
            SixthAnalysText.text = "6. ?? ?????????";
        }
    }
    public void SaveParametrs()
    {
        PlayerPrefs.SetString("SurName", SurName.text);
        PlayerPrefs.SetString("Name", Name.text);
        PlayerPrefs.SetString("DateOfBirth", DateOfBirth.text);
        PlayerPrefs.SetString("Gender", Gender.text);
        PlayerPrefs.SetString("Height", Height.text);
        PlayerPrefs.SetString("Weight", Weight.text);
        UpdateParametrs();
    }
    public void UpdateParametrs()
    {
        SurNameText.text = PlayerPrefs.GetString("SurName");
        NameText.text = PlayerPrefs.GetString("Name");
        DateOfBirthText.text = "???? ????????: " + PlayerPrefs.GetString("DateOfBirth");
        HeigthText.text = "????: " + PlayerPrefs.GetString("Height");
        WeightText.text = "???: " + PlayerPrefs.GetString("Weight");
    }

}
