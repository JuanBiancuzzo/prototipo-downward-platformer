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
        float rotation = Input.GetAxis("Horizontal");

        //Siento que esta línea podría estar más prolija
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
           
        { 
            anim.SetBool("isrunning", true);
        }
        else
            anim.SetBool("isrunning", false);


        // Flip

        Vector3 playerscale = transform.localScale;
        if (rotation < 0)
            playerscale.x = -1;

        if (rotation > 0)
            playerscale.x = 1;

        transform.localScale = playerscale;

        {

        }
        
    }

}
