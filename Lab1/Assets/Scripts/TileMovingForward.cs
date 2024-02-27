using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovingForward : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
