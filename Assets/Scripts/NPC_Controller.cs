using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{

     [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;
    private float accelerationTime = 2f;
    private float timeLeft;

    public bool stop=false;

    private void Awake()
    {
        gameObject.tag = "Enemy";
        rbody = GetComponent<Rigidbody2D>();


    }

    public void OnCollisionEnter2D(Collision2D collision){
        //collided =true;

        if (collision.gameObject.tag == "Player")
        {
            stop=true;
        }
    }

    

    void Update()
    {

        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
         }
        if(stop){
            movement.x=0;
            movement.y=0;
        }
       

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
