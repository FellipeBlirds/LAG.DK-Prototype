using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TdPlayerMovement : MonoBehaviour
{

    //https://www.youtube.com/watch?v=Vfq13LRggwk&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=4&ab_channel=MisterTaftCreates
    //4 way animation

        //A forma usada pra movimentação nesse codigo é modificando o Transform do player, existem outras formas, como usando rigidbody

    public Animator animator;

    private void Awake() 
    {
        //animator = gameObject.GetComponent<Animator>();
        //animator = animator.Find("Body");
    }

    void Update()
    {
        
        Movement();

    }

    private void Movement()
    {

        float speed = 10f;
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        //A forma usada pra movimentação nesse codigo é modificando o Transform do player, existem outras formas, como usando rigidbody

        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
        //existe a opção de usar "deltaTime" e "fixedDeltaTime"
        //https://answers.unity.com/questions/713217/exact-difference-between-fixeddeltatime-and-deltat.html
        //https://gamedevplanet.com/delta-time-vs-fixed-delta-time-differences-and-purposes/

        bool isIdle = moveX == 0 && moveY == 0;
        if (isIdle)
        {
            animator.SetBool("IsIdle", true);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Down", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Up", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
        }





        if (moveX != 0 || moveY != 0)
        //colocar esses comandos pra setar as animações dentro desse if faz com que quando voce solte o WASD o player ainda continue virado pra onde tava andando
        {
            animator.SetFloat("moveX", moveX);
            animator.SetFloat("moveY", moveY);
            animator.SetBool("moving", true);
        } 
        else
        {
            animator.SetBool("moving", false);
        }

    }

    public void Animation()
    {
        
    }

}
