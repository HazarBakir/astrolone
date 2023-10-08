using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class IntroductionAnimation : MonoBehaviour
{

    public float Speed = 1.0f;

    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);

    }
}
