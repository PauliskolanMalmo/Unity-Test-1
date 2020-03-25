using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        //test
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hInput, 0, 0) * Time.deltaTime * speed);
    }
}
