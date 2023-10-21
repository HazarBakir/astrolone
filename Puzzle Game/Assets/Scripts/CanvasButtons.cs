using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public GameObject PanelGameObject;
    public GameObject GameStoryText;
    public Animator MessageAnimationAnimator;

    public void ActivatePanel()
    {
        PanelGameObject.SetActive(true);
        GameStoryText.SetActive(true);
        MessageAnimationAnimator.SetBool("ClickedPlayButton", true);
        Debug.Log("hi");
    }

}
