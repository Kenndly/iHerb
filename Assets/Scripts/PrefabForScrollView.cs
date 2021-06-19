using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabForScrollView : MonoBehaviour
{
    // Start is called before the first frame update
    public UiController UiController;
    public string textForBlurBackGroundObject;
    void Start()
    {
        UiController = GameObject.Find("Canvas").GetComponent<UiController>();
    }

    public void OpenBlurBackAndUpdateText()
    {
        UiController.BlurBackGround.SetActive(true);
        UiController.Description.text = textForBlurBackGroundObject;
    }
}
