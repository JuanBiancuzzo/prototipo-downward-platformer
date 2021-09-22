using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitions : MonoBehaviour
{

    private Animator anim;
 

    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        { 
            anim.SetBool("isrunning", true);
        }
        else
            anim.SetBool("isrunning", false);

        // Flip

        Vector3 playerscale = transform.localScale;
        if (Input.GetKey(KeyCode.LeftArrow))
            playerscale.x = -1;

        if (Input.GetKey(KeyCode.RightArrow))
            playerscale.x = 1;

        transform.localScale = playerscale;

        {
  
        }

        
    }
}
