using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public GameObject PanelGameObject;

    public void ActivatePanel()
    {
        PanelGameObject.SetActive(true);
    }

}
