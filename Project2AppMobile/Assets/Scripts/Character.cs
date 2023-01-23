using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Rigidbody2D rb;
    [Header ("Variables para mover al personaje") ]
    public float speedWraith = 5f;
    public bool SwitchSide = true;
    public float horizontal;
    [Header("Boleanos para que se mueva o salte")]
    //public bool moveLeft;
    //public bool moveRight;
    //public bool jump;
    public int accionPlayer = -1;
    public float jumpingPower = 16f;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        //moveLeft= false;
        //moveRight= false;
        horizontal = 0;
    }

     void Update()
    {
        movePlayer();
       // horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
    }
    private void FixedUpdate()
    {
           rb.velocity = new Vector2(horizontal , rb.velocity.y);

    }

    private void Flip() 
    { //Permite voltear al personaje si se va a la derecha o izquieerda
        if(SwitchSide && horizontal < 0f || !SwitchSide && horizontal > 0f) 
        {
            SwitchSide = !SwitchSide;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void pointerDownLeft()
    { //cuando se presiona el boton 
        //moveLeft= true;
        accionPlayer = 0;
    } 
    public void pointerUpLeft()
    { //cuando no se esta presionando el boton
        //moveLeft= false;
        accionPlayer= 1;
    } 
    public void pointerDownRight()
    {
        //moveRight= true;
        accionPlayer= 2;
    } 
    public void pointerUpRight()
    {
        //moveRight= false;
        accionPlayer= 3;
    }
    public void pointerDownJump()
    {
           accionPlayer= 4;
    }
    public void pointerUpJump()
    {
        accionPlayer= 5;
    }

    private void movePlayer()
    {

        switch (accionPlayer)
        {
            case 0:
                horizontal = -speedWraith;
                break;
            case 1:
                horizontal = 0;
                break;
            case 2:
                horizontal = speedWraith;
                break;
            case 3: 
                horizontal = 0;
                break;
            case 4:
                if (IsGrounded())
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                }
                break;
                case 5:
                if (rb.velocity.y > 0f)
                {
                    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*0.5f);
                }
                break;
            default:
                horizontal= 0;
                break;
        }
        //if (moveLeft)
        //{
        //    horizontal= -speedWraith;
        //}
        //else if (moveRight)
        //{
        //    horizontal=speedWraith;
        //}
        //else
        //{
        //    horizontal = 0;
        //}
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
