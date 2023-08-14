using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
    public GameObject handLight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (handLight.activeInHierarchy)
            {
                handLight.SetActive(false);
            }
            else
            {
                handLight.SetActive(true);
            }
        }

    }
}
