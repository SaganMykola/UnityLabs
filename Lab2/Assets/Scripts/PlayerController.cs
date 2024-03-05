using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jump = 5f;
    [SerializeField] private float seconds = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space)) transform.Translate(Vector3.up * jump * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) && seconds > 0)
        {
            speed = 10;
            seconds -= Time.deltaTime;
        }
        else
        {
            speed = 5;
            if (seconds < 5) seconds += Time.deltaTime;
        }
    }
}
