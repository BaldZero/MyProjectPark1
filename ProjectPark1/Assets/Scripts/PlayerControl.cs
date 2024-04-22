using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float moveSpeed = 25f;
    public float health = 100f;
    public Rigidbody rb;

    public float mapBoundary = 25f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        
        if(transform.position.x > mapBoundary)
        {
            transform.position = new Vector3(mapBoundary, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -mapBoundary)
        {
            transform.position = new Vector3(-mapBoundary, transform.position.y, transform.position.z);
        }
        if (transform.position.z > mapBoundary)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, mapBoundary);
        }
        if((transform.position.z < -mapBoundary))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -mapBoundary);
        }
    }
}
