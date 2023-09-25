using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGFX : MonoBehaviour
{
    public AIPath AiPath;
    public SpriteRenderer SpriteRenderer;

    private void Update()
    {
        if (AiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (AiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }


    }
}
