using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdNo : MonoBehaviour {
    public float Speed = 2f;

    public float force = 300f;

    //private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    //private KeywordRecognizer keywordRecognizer;
    // Use this for initialization


    void Start()
    {
        //keywordActions.Add("up",Up);
        //keywordActions.Add("down",Down);
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;

        //keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        //keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        //keywordRecognizer.Start();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);

    }

    private void Up()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
}
