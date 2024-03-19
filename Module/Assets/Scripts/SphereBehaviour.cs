using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _cue;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cue"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1000);
            _cue.SetActive(false);
        }
    }
}
