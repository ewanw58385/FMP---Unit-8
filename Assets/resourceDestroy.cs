using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && GameObject.Find("Player").GetComponent<playerController>().playCoinAnim == true) //if within collider and player has pressed Pickup button
        {
            Destroy(gameObject);
        }
    }
}
