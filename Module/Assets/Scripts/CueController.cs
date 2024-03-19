using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CueController : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) _sphere.transform.Rotate(Vector3.up * (Time.deltaTime * 20));
        
        if (Input.GetKey(KeyCode.RightArrow)) _sphere.transform.Rotate(Vector3.down * (Time.deltaTime * 20));
        
        if (Input.GetKey(KeyCode.Space)) transform.Translate(Vector3.up * (Time.deltaTime * 10));

    }
}
