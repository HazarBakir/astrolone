using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameStopMenu;
    private bool _isGamePaused = false;


  
    private void Update()
    {
        StopTheGame();
    }

    private void StopTheGame()
    {
        if (!Input.GetKeyDown(KeyCode.P) && !Input.GetKeyDown(KeyCode.Escape)) return;
        if (_isGamePaused)
        {
            _isGamePaused = false;
            GameStopMenu.SetActive(false);

        }
        else
        {
            _isGamePaused = true;
            GameStopMenu.SetActive(true);
        }
    }
}
