using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceGatherer : MonoBehaviour
{

    public Rigidbody2D rb; //first method 
    public Transform resourcePosition;
    public GameObject coin; //2nd method 


    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Resource" && GameObject.Find("Player").GetComponent<playerController>().playCoinAnim == true) //if within collider and player has pressed Pickup button
        {
            Debug.Log("Picked up item");

            //Instantiate(rb, resourcePosition.position, resourcePosition.rotation); //first method - not working

            coin = Instantiate(coin);
            coin.transform.position = resourcePosition.transform.position; //2nd method, not working
            coin.transform.rotation = resourcePosition.transform.rotation;

            //I have ensured coin transform at 0,0,0, matches other gameobjects 0,0,0(reset) transform. there is not a problem with alignment. 
        }
    }
}
