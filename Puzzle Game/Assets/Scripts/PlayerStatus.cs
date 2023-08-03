using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public TMP_Text oxygenCounter;
    public float oxygen_counter;

    void Start()
    {
        oxygen_counter = 100;
        StartCoroutine(LoseOxygen());
    }

    private IEnumerator LoseOxygen()
    {
        while (oxygen_counter > 0f)
        {
            oxygen_counter -= 1;
            oxygenCounter.SetText(oxygen_counter.ToString());
            yield return new WaitForSeconds(2f);
        }
        
    }
}


//if (oxygen_counter > 0f)
//{
//    oxygen_counter = Mathf.Max(0f, oxygen_counter - 0.5f * Time.deltaTime);
//    oxygenCounter.text = ((int)oxygen_counter).ToString();
//}