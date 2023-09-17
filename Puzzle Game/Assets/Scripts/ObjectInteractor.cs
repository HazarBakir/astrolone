using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractor : MonoBehaviour
{
    public GameObject InteractionableObject; // for to destroy the object after taking the object.
    public GameObject InteractGameObject; // for to activate the object after taking the object.
    private bool inTriggerZone = false;
    public ObjectInteractionMessages ObjectMessages;
    private void Start()
    {
        ObjectMessages = FindAnyObjectByType<ObjectInteractionMessages>();
    }

    void Update()
    {
        ActivateObject();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ManageTriggerZone(true,collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ManageTriggerZone(false, collision);
        }
    }

    void ActivateObject()
    {
        if(inTriggerZone && Input.GetKeyDown(KeyCode.E))
        {
            if (ObjectMessages.takeItemsText.isActiveAndEnabled)
            {
                //Debug.Log("what?");
                InteractGameObject.SetActive(true);
                Destroy(InteractionableObject);
            }
            else if (ObjectMessages.interactionText.isActiveAndEnabled)
            {
                //Debug.Log("yes");
                Destroy(InteractGameObject);
                Destroy(InteractionableObject);
            }
        }
        
    }
    void ManageTriggerZone(bool activated,Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inTriggerZone = activated;
        }
    }
}
