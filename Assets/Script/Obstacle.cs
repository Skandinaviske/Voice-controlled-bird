using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed;

    public float SwitchTime;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        InvokeRepeating("Switch", 0, SwitchTime);

	}

    void Switch()
    {

        GetComponent<Rigidbody2D>().velocity *= -1;
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel(7);
    }

}
