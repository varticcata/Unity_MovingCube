using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    float speed = 10;
    [SerializeField] float verticalInput;
    float horizontalInput;
    Rigidbody cubeRb;

    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        cubeRb.AddForce(Vector3.right * horizontalInput * speed);
        cubeRb.AddForce(Vector3.forward * verticalInput * speed);
    }
}
