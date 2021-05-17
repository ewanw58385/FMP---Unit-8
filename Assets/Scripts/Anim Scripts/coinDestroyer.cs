﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDestroyer : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((anim.GetCurrentAnimatorStateInfo(0).IsName("coinSpinAnim")) && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.8f)

        {
            Destroy(gameObject);       
        }

    }
}
