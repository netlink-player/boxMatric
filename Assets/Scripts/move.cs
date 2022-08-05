using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    private float speed = 8f;
    private int checkMove = 1;
    void Start()
    {  
       rb = GetComponent<Rigidbody2D>();
       moveLeft = false;
       moveRight = false; 
    }
    public void PointerDownLeft()
    {
        moveLeft = true;
        checkMove = 2;
    }
 
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
 
    public void PointerDownRight()
    {
        moveRight = true;
        checkMove = 1;
    }
 
    public void PointerUpRight()
    {
        moveRight = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
 
    private void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            gameObject.transform.localScale = new Vector2 ( -1, gameObject.transform.localScale.y );
        }
        else if (moveRight)
        {
            horizontalMove = speed;
            gameObject.transform.localScale = new Vector2 ( 1, gameObject.transform.localScale.y );
        }
        else
        {
            horizontalMove = 0;
        }
       rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
    // private void FixedUpdate()
    // {
    //     rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    // }
    public int check(){
        return checkMove;
    }
}
