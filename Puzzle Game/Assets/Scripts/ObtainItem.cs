using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainItem : MonoBehaviour
{
    public GameObject obtainableObject;
    public GameObject obtainGameObject;
    private bool inTriggerZone = false;

    void Update()
    {
        if (inTriggerZone && Input.GetKeyDown(KeyCode.E))
        {
            obtainGameObject.SetActive(true);
            Destroy(obtainableObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inTriggerZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inTriggerZone = false;
        }
    }
}
