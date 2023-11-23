using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasButtons : MonoBehaviour
{
    public GameObject PanelGameObject;
    public GameObject GameStoryText;
    public Animator MessageAnimationAnimator;

    void Update()
    {
           
    }

    public void ActivatePanel()
    {
        PanelGameObject.SetActive(true);
        GameStoryText.SetActive(true);
        MessageAnimationAnimator.SetBool("ClickedPlayButton", true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
