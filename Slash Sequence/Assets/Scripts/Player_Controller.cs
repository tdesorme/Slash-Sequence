using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    bool isOnGround;
    bool isIdle;
    bool isWalking = false;
   // bool isWalkingBack = false;

    Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isIdle = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
    {
           if (isIdle)
           {
                if (Input.GetKey(KeyCode.W)){
                    isWalking = true;
               
                    transform.Translate(0f, 0f, 2f * Time.deltaTime);
                   
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    isWalking = true;
                  
                    transform.Translate(-1*(2f * Time.deltaTime), 0f, 0f);
                   
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    isWalking = true;
              
                    transform.Translate((2f * Time.deltaTime), 0f, 0f);
                   
                }
                else if (Input.GetKey(KeyCode.S))
                {
                 
                    transform.Translate(0f, 0f, -1f * Time.deltaTime);
          
                    
                }

                if (isWalking)
                {
        
                    Debug.Log("is Walking");
                    animator.SetBool("isIdle", false);
                    animator.SetBool("isWalking", true);
                }
             
               
           }
       }
        else
        {
            animator.SetBool("isIdle", true);
            animator.SetBool("isWalking", false);
        }

      


    }
}
