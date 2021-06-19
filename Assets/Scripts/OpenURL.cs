using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void GoToURL(string url)
    {
        Application.OpenURL(url);
    }
}
