using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Controller : MonoBehaviour
{

     [SerializeField]
    private float movementSpeed;
    private Vector2 movement;
    private Rigidbody2D rbody;
    private float timeLeft;

    public bool stop=false;

    public GameObject target;

    private void Awake()
    {
        gameObject.tag = "Enemy";
        rbody = GetComponent<Rigidbody2D>();


    }

    private void Start(){
        target = GameObject.Find("Player");

        this.gameObject.GetComponent<SpriteRenderer>().color=Color.black;

        
        Debug.Log(target.transform.position);

        
    }

    

    private void Update(){
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, .03f);
    }

    
   

}
