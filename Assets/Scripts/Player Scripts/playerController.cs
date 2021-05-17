using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float startTime, endTime;
    public bool isPickingUpItem = false;
    public bool playCoinAnim = false;
    private int lastDirection;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement; 
    

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        CallAnimManagers();

        movement.x = Input.GetAxisRaw("Horizontal"); //gets axis as vector2 
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);  //sets animation parameters
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }  

    void CallAnimManagers()
    {
        FacingIdleManager();
        ResourceGatherManager();
    }
    
    void FacingIdleManager()
    {
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) 
        //If statement to set the correct idle animation (idle right, left, down) based off last direction.
        {
            anim.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));

        }
    }

    void ResourceGatherManager()
    {
        if (movement.x > 0) //Detects last direction
        {
            lastDirection = 1;
        }
        if (movement.x < 0)
        {
            lastDirection = -1;
        }

        if (Input.GetKeyDown(KeyCode.E) && lastDirection == -1)
        {
            anim.Play("pickupLeft"); //play anim
            isPickingUpItem = true; //freeze movement

            playCoinAnim = true;
        }
            if (Input.GetKeyDown(KeyCode.E) && lastDirection == 1) 
            {
                anim.Play("pickupRight"); 
                isPickingUpItem = true;

                playCoinAnim = true;    
        }

        if ((anim.GetCurrentAnimatorStateInfo(0).IsName("pickupLeft") || anim.GetCurrentAnimatorStateInfo(0).IsName("pickupRight")) && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.8f)
        {
            isPickingUpItem = false;

        }
        if ((anim.GetCurrentAnimatorStateInfo(0).IsName("pickupLeft") || anim.GetCurrentAnimatorStateInfo(0).IsName("pickupRight")) && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.05f) //stop instansiating prefabs after 0.05f. 
        {
            playCoinAnim = false;
        }
    }

    void AnimationTimingMethod()
    {

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

        if (isPickingUpItem == false)
        {
            rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime); //applies movement to player
        }
    }

}
