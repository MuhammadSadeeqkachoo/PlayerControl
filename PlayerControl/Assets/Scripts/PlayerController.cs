using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody player_rb;
    private float Range = 18 ;
    // Start is called before the first frame update
    void Start()
    {
       player_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        MovementRange();

    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        player_rb.AddForce(Vector3.forward * speed * verticalInput);
        player_rb.AddForce(Vector3.right * speed * horizontalInput);
    }

    private void MovementRange()
    {
        if (transform.position.x > Range)
        {
            transform.position = new Vector3(Range, 1.36f, transform.position.z);
        }
        else if (transform.position.x < -Range)
        {
            transform.position = new Vector3(-Range, 1.36f, transform.position.z);
        }
        else if (transform.position.z > Range)
        {
            transform.position = new Vector3(transform.position.x, 1.36f,Range );
        }
        else if (transform.position.z < -Range)
        {
            transform.position = new Vector3(transform.position.x, 1.36f, -Range);
        }

    }
}
