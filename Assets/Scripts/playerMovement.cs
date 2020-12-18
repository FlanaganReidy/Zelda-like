using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5f;

    public Rigidbody2D rb;
    public Animator theAnimator;
    public VectorValue startingPosition;

    public Vector2 movement;

    // Update is called once per frame
    void Start()
    {
      transform.position = startingPosition.initialValue;
    }
    void Update()
    {
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");

      theAnimator.SetFloat("Horizontal", movement.x);
      theAnimator.SetFloat("Vertical", movement.y);
      theAnimator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() 
    {
        movement.Normalize();
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
