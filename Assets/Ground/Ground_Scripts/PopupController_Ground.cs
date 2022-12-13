
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController_Ground : MonoBehaviour
{
    public GameObject Popup;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Popup.SetActive(true);
        }
    }

    public void OnClickExit()
    {
        Popup.SetActive(false);
    }

}