using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Controller : MonoBehaviour
{

     [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;
    public TextMeshProUGUI txt;
    private int counter=0;
 
    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        txt.SetText(counter.ToString());
    }


    public void OnCollisionEnter2D(Collision2D collision){
        //collided =true;

        if (collision.gameObject.tag == "Enemy")
        {
            
            counter++;

            txt.SetText(counter.ToString());
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
