using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FlickeringLight : MonoBehaviour
{
    public Light2D Light;
    public float MinTime;
    public float MaxTime;
    public float Timer;


    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    // Update is called once per frame
    void Update()
    {
        FlickerLight();
    }

    private void FlickerLight()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }

        if (!(Timer < 0)) return;
        Light.enabled = !Light.enabled;
        Timer = Random.Range(MinTime, MaxTime);
    }

}
