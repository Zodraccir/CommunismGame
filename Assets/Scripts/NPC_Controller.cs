using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{

     [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;


    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        movement.x = Random.Range(-0.5f, 0.5f);
        movement.y = Random.Range(-0.5f, 0.5f);

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
