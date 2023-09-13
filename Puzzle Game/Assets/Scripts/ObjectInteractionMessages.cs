using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectInteractionMessages : MonoBehaviour
{
    public TMP_Text interactionText;
    public TMP_Text takeItemsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            interactionText.gameObject.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("Obtainable"))
        {
            takeItemsText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("Interactable"))
        {
            interactionText.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Obtainable"))
        {
            takeItemsText.gameObject.SetActive(false);
        }

    }
}
