using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool moveUp = false;
    private bool moveDown = false;

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float upwardForce = 5f;
    [SerializeField]
    private float downwardForce = 5f;
    [SerializeField]
    private float acceleration = 2f;
    [SerializeField]
    [Range(1f, 20f)]
    private float speedUpDown = 5;

    [SerializeField]
    private float verticalVelocity = 0f;
    [SerializeField]
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = Input.GetKey(KeyCode.UpArrow);
        moveDown = Input.GetKey(KeyCode.DownArrow);

        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        verticalVelocity = verticalInput * speedUpDown;

        /* if (moveUp)
        {
            Debug.Log("nach oben bewegen!");
            verticalVelocity = upwardForce;
        }
        else if (moveDown)
        {
            Debug.Log("Nach unten bewegen!");
            verticalVelocity = -downwardForce;
        } */

        rb.velocity = new Vector2(acceleration, verticalVelocity);
    }
}
