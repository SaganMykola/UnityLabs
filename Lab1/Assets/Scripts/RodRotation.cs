using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 45f;

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
