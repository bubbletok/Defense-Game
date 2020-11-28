using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDisappear : MonoBehaviour
{
    public float waitTime;
    float timer;
    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
            Destroy(gameObject);
    }
}
