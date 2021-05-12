using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceGatherer : MonoBehaviour
{
    public GameObject coin; //first method 
    public Transform resourcePosition;

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<playerController>().playCoinAnim == true) //if within collider and player has pressed Pickup button
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<playerController>().playCoinAnim == true) //if within collider and player has pressed Pickup button
        {
            Debug.Log("Picked up item");
            
            Instantiate(coin, resourcePosition.position, resourcePosition.rotation);     
        }
    }
}

