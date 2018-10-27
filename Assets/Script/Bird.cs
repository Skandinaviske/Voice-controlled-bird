using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
    public float Speed = 2f;


    public float volume;
    public float jumpForce = 2000;
    
    float tempTime = 0;

    public float maxSpeed = 5f;
    //public float force = 300f;



    // Use this for initialization
    //void Start()
    //{

    //}


    void Start () {

        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;

    }

    void Update()
    {

        volume = NewBehaviourScript.volume;  // 0 ~ 1
        if (volume > 0.01)
        {
            if (Time.time - tempTime > 0.05) //current time - temptime > 1 sec
           {                             // get the bird back
                Jump();
                tempTime = Time.time;
            }
        }



    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce * volume); // add F. vector2 x y=1


    }

    
}


