    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public GameObject pressKey;
   

    private void Start()
    {
        CloseKeyPanel();
    }
    public void OpenKeyPanel()
    {
        pressKey.SetActive(true);

    }
    public void CloseKeyPanel()
    {
        pressKey.SetActive(false);
    }

   
}
