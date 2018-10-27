using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG : MonoBehaviour {

    public float Speed = 2f;


    public float force = 300f;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
