using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

     [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;

 
    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }


    public void OnCollisionEnter2D(Collision2D collision){
        //collided =true;

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("ciao");
            //collision.gameObject.SendMessage("ApplyDamage", 10);
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        Vector2 currentPos = rbody.position;

        Vector2 adjustedMovement = movement * movementSpeed;

        Vector2 newPos = currentPos + adjustedMovement * Time.fixedDeltaTime;

        rbody.MovePosition(newPos);
    }

   

}
