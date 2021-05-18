using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceGatherer : MonoBehaviour
{
    public GameObject coin;
    public Transform resourcePosition;
    public bool preventsMultiplePickups = false;
    Animator anim;
    private bool isCollected = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<playerController>().playCoinAnim == true) && (isCollected == false)) //if within collider and player has pressed Pickup button
        {
            anim.SetTrigger("hasCollected2"); //resource animation
            Instantiate(coin, resourcePosition.position, resourcePosition.rotation); //instantiate coin anim
            Debug.Log("Picked up item");
        }
    }

    void DestroyResource()
    {
        Destroy(gameObject);
    }


    /*void Update()
    {

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("resourceBreak")) 
        {
            Debug.Log("cannot pickup items");
        }
        else
        {
            Debug.Log("can pickup items");
        }
    }*/
}

