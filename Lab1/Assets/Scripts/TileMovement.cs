using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class TileMovement: MonoBehaviour
    {
        [SerializeField] public float speed = 10f;
        [SerializeField] public float interval = 5f;

        private void Start()
        {
            StartCoroutine(ChangeDirectionCoroutine());
        }
    
        private void Update()
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
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
}