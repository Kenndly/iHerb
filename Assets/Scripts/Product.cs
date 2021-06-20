using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Product : MonoBehaviour
{
    public List<string> BadComponnets = new List<string>();
    public string ProductName;
    public TextMeshProUGUI productNameText;
    public UiController UiController;

    private void Start()
    {

    }
    private void Awake()
    {
        UiController = GameObject.Find("Canvas").GetComponent<UiController>();
    }
    public void UpdateTextAndComponents()
    {
        productNameText.text = ProductName.ToLower();
        switch (ProductName.ToLower())
        {
            case "���":
                BadComponnets.Add("������");
                BadComponnets.Add("��������");
                break;
            case "���":
                BadComponnets.Add("������");
                BadComponnets.Add("��������");
                break;
            case "���������� �������":
                BadComponnets.Add("��������");
                BadComponnets.Add("������");
                break;
            case "������������":
                BadComponnets.Add("������");
                BadComponnets.Add("��������");
                break;
            case "����������":
                BadComponnets.Add("������");
                BadComponnets.Add("��������");
                break;
            case "�������":
                BadComponnets.Add("������");
                BadComponnets.Add("��������");
                break;
        }
        UiController.products.Add(this);
    }
    public void Remove()
    {
        UiController.products.Remove(this);
        Destroy(gameObject);
    }
    //public void CheckForLink(List<Product> otherProducts)
    //{
    //    foreach (Product product in otherProducts)
    //    {
    //        foreach (string commponents in product.Componnets)
    //        {
    //            foreach (string mycommponent in gameObject.GetComponent<Product>().BadComponnets)
    //            {
    //                if (mycommponent == commponents)
    //                {
    //                    print("������ ��������� " + commponents);
    //                }
    //            }
    //        }
    //    }
    //}
}
