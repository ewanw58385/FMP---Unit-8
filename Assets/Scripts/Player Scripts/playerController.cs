using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement; 

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal"); //gets axis as vector2 
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);  //sets animation parameters
        anim.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) 
        //If statement to set the correct idle animation (idle right, left, down) based off last direction.
        {
            anim.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));

        }
    }  
    
    void FixedUpdate()
    {

        if (Mathf.Abs(movement.x) > Mathf.Abs(movement.y)) //if statement disables diagonal movement
        {
            movement.y = 0;
        }
        else
        {
            movement.x = 0;
        }

        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime); //applies movement to player
    }

}
