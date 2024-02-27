using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycloid : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float time = 1f;
    [SerializeField] private float interval = 1f;

    private void Start()
    {
        StartCoroutine(ChangeDirectionCoroutine());
    }

    void Update()
    {
        float x = 2 * (time - Mathf.Sin(time));
        float y = 2 * (1 - Mathf.Cos(time));
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);

        time += Time.deltaTime * speed;
    }
    
    private IEnumerator ChangeDirectionCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            speed *= -1;
        }
    }
}
