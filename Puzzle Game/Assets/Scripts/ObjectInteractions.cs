using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectInteractions : MonoBehaviour
{
    public bool isActivated = false;
    public TMP_Text interactionText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isActivated == false)
            {
                interactionText.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Player")
        {
            interactionText.gameObject.SetActive(false);
        }
    }
}
