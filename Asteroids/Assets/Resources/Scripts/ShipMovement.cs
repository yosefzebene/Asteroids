using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;               // Character speed
    private Rigidbody2D rb;           // Rigidbody component
    private Vector2 moveVelocity;     // Moving velocity

    // Start is called before the first frame update
    void Start()
    {
        // Get rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        FaceMouse();
    }

    void FixedUpdate() {
        rb.AddForce(moveVelocity);
    }

    void FaceMouse(){
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;
    }
}
