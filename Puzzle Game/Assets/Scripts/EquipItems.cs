using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
    public GameObject handLight;
    public GameObject pistol;
    public GameObject assault_rifle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandLightActivation();
        EquipGuns();
    }
    void HandLightActivation()
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
    void EquipGuns()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (pistol.activeInHierarchy)
            {
                pistol.SetActive(false);
            }
            else
            {
                assault_rifle.SetActive(false);
                pistol.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (assault_rifle.activeInHierarchy)
            {
                assault_rifle.SetActive(false);
            }
            else
            {
                assault_rifle.SetActive(true);
                pistol.SetActive(false);
            }
        }
    }
}
