using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideIntroText : MonoBehaviour
{

    //delete this file
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("IntroText"))
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }
}
