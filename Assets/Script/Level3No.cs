using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3No : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel(3);
    }
}
