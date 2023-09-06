using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class EquipItems : MonoBehaviour
{
    public GameObject handLight;
    public GameObject pistol;
    public GameObject assault_rifle;
    public bool hasAssaultRifle;
    public bool hasPistol;

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
                DeactiveTheObject(handLight);
            }
            else
            {
                ActiveTheObject(handLight);
            }
        }
    }
    void EquipGuns()
    {
        if (pistol.activeInHierarchy)
        {
            hasPistol = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && hasPistol == true)
        {
            if (pistol.activeInHierarchy)
            {
                DeactiveTheObject(pistol);
            }
            else
            {
                DeactiveTheObject(assault_rifle);
                ActiveTheObject(pistol);
            }


        }

        if (assault_rifle.activeInHierarchy)
        {
            hasAssaultRifle = true;            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && hasAssaultRifle == true)
        {
            if (assault_rifle.activeInHierarchy)
            {
                DeactiveTheObject(assault_rifle);
            }
            else
            {
                ActiveTheObject(assault_rifle);
                DeactiveTheObject(pistol);
            }
        }



    }
    void ActiveTheObject(GameObject obj)
    {
        obj.SetActive(true);
    }
    void DeactiveTheObject(GameObject obj)
    {
        obj.SetActive(false);
    }
}
