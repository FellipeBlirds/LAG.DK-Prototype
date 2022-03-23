using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatPlayerMovement : MonoBehaviour
{

    //https://www.youtube.com/watch?v=Gf8LOFNnils&ab_channel=Pandemonium

    private Rigidbody2D rb2d;

    public Animator animator;

    public bool grounded;

    public SpriteRenderer spriteRenderer;
    //sprite renderer do corpo do personagem, que vai ser flipado

    //public int speed;

    private void Awake() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        Movement();
    }

    private void Movement()
    {
        float speed = 10f;
        float moveX = 0f;
        
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }

        //parte do codigo pra flipar o sprite
        if (moveX > 0)
        {
            spriteRenderer.flipX = false;
            //transform.localScale = Vector3.one;
            //eu prefiro fazer isso com o Flip, só dar uma pesquisada e pá
        } 
        else if (moveX < 0)
        {
            spriteRenderer.flipX = true;
            //transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, speed);
            grounded = false;
            
        }

        animator.SetBool("grounded", grounded);

        //A forma usada pra movimentação nesse codigo é modificando o Transform do player, existem outras formas, como usando rigidbody

        Vector3 moveDir = new Vector3(moveX, 0);
        transform.position += moveDir * speed * Time.deltaTime;
        //novamente aqui dá pra fazer a movimentação de diversas formas diferente, aqui eu to mudando o a posição do transform
        //eu preciso dar uma estudada nas formas de fazer isso e decidir qual é a melhor
        //eu posso fazer diferentes funções de movimentação, cada uma funcionando de uma forma, e ai dependendo do jogo que eu for fazer eu só escolho qual vai estar em uso


        if (moveX != 0)
        //colocar esses comandos pra setar as animações dentro desse if faz com que quando voce solte o WASD o player ainda continue virado pra onde tava andando
        {
            animator.SetBool("moving", true);
        } 
        else
        {
            animator.SetBool("moving", false);
        }


        
        //Fazer um graunded decente
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    

}
