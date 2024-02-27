using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickerBehaviour : MonoBehaviour
{
    public float amplitude = 45f;

    void Update()
    {
        float angle = amplitude * Mathf.Sin(2 * Time.time);
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
